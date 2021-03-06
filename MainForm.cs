using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using Antlr4.Runtime.Tree;
using System.Globalization;

namespace IDE_for_SIC_ASM
{
    public partial class MainForm : MaterialForm
    {
        public Dictionary<string, string> tabsim;
        public List<long> PCs; // Program counters
        int startAddr = 0;
        int length = 0;
        int endAddr = 0;
        bool isXE = false;
        bool canRunObj = false;
        
        public static Dictionary<String, int> Registers = new Dictionary<String, int>()
        {
            {"A", 0xFFFF},
            {"CP", 0xFFFF},
            {"DEV", 0xFFFF},
            {"L", 0xFFFF},
            {"X", 0xFFFF},
            {"SW", -1}
        };

        struct ParseResult
        {
            public SicGrammarParser parser; // Instancia del parser
            public IList<IToken> tokens; // Lista de tokens de la linea
            public String type; // Variable para indicar si es instruccion, directiva, START, END, etc.
            public uint num; // Localidad de memoria (Opcional)
            public bool success; // Bandera de exito

            public String symbol; // Identificador de la instruccion (Opcional)
            public String instruction; //  Mas especifico que instruccion o directiva es, ADD, RSUB, RESB, etc.
            public String op; // Operador de la instruccion. Es una etiqueta (Opcional)
            public Boolean index; // Indica si el operador es indexado
            public String obj;
            public bool isFormat4;
        }

        public MainForm()
        {
            InitializeComponent();
            // Configuracion de Material Theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Blue100, Accent.Yellow400, TextShade.WHITE);

            TextBoxEditor.BackColor = Color.FromArgb(43, 43, 43);
            TextBoxEditor.ForeColor = Color.FromArgb(169, 183, 197);
            TextBoxEditor.CaretColor = Color.FromArgb(169, 183, 197);
            //BackColor = Color.FromArgb(66, 66, 80);
            PCs = new List<long>();

            foreach (var r in Registers)
            {
                String[] data = new String[]
                {
                    r.Key, r.Value.ToString()
                };
                gridRegisters.Rows.Add(data);
            }

            tabsimGrid.Rows[0].DataGridView.ForeColor = Color.Black;
        }

        private void FillRow(int line, long PC, ParseResult result)
        {
            if (isXE)
                result.obj = "";

            String[] data =
            {
                    line.ToString(), PC.ToString("X").PadLeft(4, '0'), result.symbol, result.instruction, result.op, result.obj
            };
            gridSourceCode.Rows.Add(data);
            
            gridSourceCode.Rows[gridSourceCode.Rows.Count - 1].DataGridView.ForeColor = Color.Black;
        }

        private ParseResult ParseLine(String line, int lineNumber, String type)
        {
            bool success = true;
            var result = new ParseResult();
            SicGrammarLexer lex = new SicGrammarLexer(new AntlrInputStream(line + Environment.NewLine));
            CommonTokenStream tokens = new CommonTokenStream(lex);
            SicGrammarParser parser = new SicGrammarParser(tokens);
            parser.AddErrorListener(new MyErrorListener());

            try
            {
                switch (type)
                {
                    case "start": parser.inicio(); break;
                    case "body": parser.proposicion(); break;
                    case "end": parser.fin(); break;
                }
            }
            catch (Exception error)
            {
                if (!error.Message.Contains("input ' '") &&
                    !error.Message.Contains("expecting {',', SEP}"))
                {
                    tbErrors.Text += @"Linea " + (lineNumber+1) + " con error: " + error.Message;
                    tbErrors.Text += "\r\n";
                    success = false;
                }
            }

            result.parser = parser;
            result.tokens = tokens.GetTokens();
            result.success = success;
            result.num = 40;

            var instructDetected = false;
            var isFormat4 = false;
            bool isFormat2 = false;

            foreach (var t in tokens.GetTokens())
            {
                String tokenType = parser.Vocabulary.GetDisplayName(t.Type);

                switch (tokenType)
                {
                    case "INSTRUNO":
                        result.type = "INST1";
                        result.instruction = t.Text;
                        instructDetected = true;
                        break;
                    case "INSFDOSRN":
                    case "INSFDOSR":
                    case "INSFDOSRR":
                    case "'SVC'":
                        result.type = "INST2";
                        result.instruction = t.Text;
                        instructDetected = true;
                        isFormat2 = true;
                        int start = tokens.GetTokens().IndexOf(t)+1;
                        List<IToken> subListTokens = tokens.GetTokens().ToList().GetRange(start, tokens.GetTokens().Count() - start);
                        string instrOp = "";
                        foreach (var item in subListTokens)
                            instrOp += (Text.Trim() == "\n" || item.Text.Trim() == "<EOF>") ? "" : item.Text.Trim();
                        result.op = instrOp;
                        break;
                    case "INSTRES":
                        result.type = isFormat4 ? "INST4" : "INST3";
                        result.instruction = isFormat4 ? "+" : "";
                        result.instruction += t.Text;
                        instructDetected = true;
                        break;
                    case "TIPODIRECTIVA":
                        result.type = t.Text;
                        result.instruction = t.Text;
                        instructDetected = true;
                        break;
                    case "'RSUB'":
                        result.instruction = "RSUB";
                        result.type = "RSUB";
                        break;
                    case "'START'":
                        result.instruction = "START";
                        break;
                    case "'END'":
                        result.instruction = "END";
                        break;
                    case "BYTEOP":
                        result.type = "BYTE";
                        result.instruction = "BYTE";
                        result.op = t.Text;
                        result.num = (uint) t.Text.Length - 3;

                        if(t.Text.First() == 'X')
                            result.num = (uint) Math.Ceiling((double)result.num / 2);
                        break;
                    case "NUM":
                        if(!isFormat2)
                        {
                            result.op = t.Text;
                            if (t.Text.Last() == 'H' || t.Text.Last() == 'h')
                            {
                                uint.TryParse(t.Text.Remove(t.Text.Count() - 1),
                                    NumberStyles.HexNumber,
                                    CultureInfo.CurrentCulture,
                                    out result.num);
                            }
                            else
                            {
                                success = uint.TryParse(t.Text,
                                    out result.num);
                            }
                        }
                        break;
                    case "ID":
                        if (instructDetected)
                            result.op = t.Text;
                        else
                            result.symbol = t.Text;
                        break;
                    case "INDEX":
                        if(isFormat2)
                        {
                            result.index = false;
                            result.success = true;
                            result.op += ", X";
                        }
                        else
                        {
                            result.index = true;
                            result.op += ", X";
                        }
                        break;
                    case "'+'":
                        isFormat4 = true;
                        break;
                    case "'BASE'":
                        instructDetected = true;
                        result.type = "BASE";
                        result.instruction = "BASE";
                        break;
                }
            }

            return result;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            PCs.Clear();
            canRunObj = false;

            if (CurrentFileName.Text == "...")
            {
                MessageBox.Show("To run the assembly you need to open an ASM or ASMX file");
                return;
            }

            // Store program counters of every line
            string contents = File.ReadAllText(CurrentFileName.Text);
            List<String> lines = contents.Replace("\r", " ").Split('\n').ToList();
            tbErrors.Text = "";
            gridSourceCode.Rows.Clear();
            tabsimGrid.Rows.Clear();
            objFileTextBox.Text = "";

            // Parse first line
            var result = ParseLine(lines[0], 0, "start");
            PCs.Add(result.num);
            FillRow(1, PCs.First(), result);

            // Parse ASM content
            for (int i = 1; i < lines.Count - 1; i++)
            {
                result = ParseLine(lines[i], i, "body");

                if(result.success)
                {
                    switch (result.type)
                    {
                        case "INST1":
                            PCs.Add(PCs.Last() + 1); break;
                        case "INST2":
                            PCs.Add(PCs.Last() + 2); break;
                        case "INST3":
                        case "WORD":
                        case "RSUB":
                            PCs.Add(PCs.Last() + 3); break;
                        case "INST4":
                            PCs.Add(PCs.Last() + 4); break;
                        case "BYTE": PCs.Add(PCs.Last() + result.num); break;
                        case "RESB": PCs.Add(PCs.Last() + result.num); break;
                        case "RESW": PCs.Add(PCs.Last() + result.num * 3); break;
                    }

                    FillRow(i + 1, PCs[PCs.Count - 2], result);
                } else
                {
                    FillRow(i + 1, PCs.Last(), result);
                }
            }

            // Parse END line
            result = ParseLine(lines.Last(), lines.Count, "end");
            FillRow(lines.Count, PCs.Last(), result);

            tabsim = GenerateTabsim();
            long size = PCs.Last() - PCs.First();
            progSize.Text = size.ToString("X");

            //Step 2
            if(!isXE)
            {
                GenerateObj();
                GenerateObjFile();

                if (tbErrors.Text == "")
                    MessageBox.Show("Your grammar rules! ");
                else
                    File.WriteAllText("output.txt", tbErrors.Text);

                GenerateMapMemory();
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog {
                Filter = "asmx files (*.asmx)|*.asmx|asm files (*.asm)|*.asm",
                FilterIndex = 3
            };

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFileName.Text = OpenDialog.FileName;
                TextBoxEditor.Text = File.ReadAllText(OpenDialog.FileName);

                isXE = Path.GetExtension(OpenDialog.FileName) == ".asmx";
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (CurrentFileName.Text == "...")
            {
                SaveFileDialog saveDialog = new SaveFileDialog {
                    Filter = "txt files (*.txt)|*.txt|asm files (*.asm)|*.asm",
                    FilterIndex = 2
                };
                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return;
                CurrentFileName.Text = saveDialog.FileName;
            }
            File.WriteAllText(CurrentFileName.Text, TextBoxEditor.Text);
        }
        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            materialTabControl1.Width = Convert.ToInt32(this.Width * 1.1);
        }

        private Dictionary<string,string> GenerateTabsim()
        {
            Dictionary<string, string> DiccOut = new Dictionary<string, string>();

            for (int i = 0; i < gridSourceCode.RowCount; i++)
            {
                if(gridSourceCode.Rows[i].Cells[2].Value != null)
                {
                    if (!DiccOut.Keys.Contains(gridSourceCode.Rows[i].Cells[2].Value.ToString()))
                    {
                        DiccOut.Add(gridSourceCode.Rows[i].Cells[2].Value.ToString(),
                            gridSourceCode.Rows[i].Cells[1].Value.ToString());

                        String[] data =
                        {
                            gridSourceCode.Rows[i].Cells[2].Value.ToString(),
                            gridSourceCode.Rows[i].Cells[1].Value.ToString()
                        };
                        tabsimGrid.Rows.Add(data);
                    }
                }
            }
            return DiccOut;
        }

        private void GenerateObj()
        {

            for (int i = 0; i < gridSourceCode.RowCount; i++)
            {
                string objectCode = "----------";
                if (gridSourceCode.Rows[i].Cells[3].Value != null)
                {
                    var instruction = gridSourceCode.Rows[i].Cells[3].Value.ToString(); // (LDA, ADD, etc) or (RESW, RESB, etc) 
                    var op = gridSourceCode.Rows[i].Cells[4].Value; // 00H, ZERO, 25

                    if (InstructionSet.Data.ContainsKey(instruction))
                    {   //es una instruccion
                        objectCode = String.Format("{0:x2}", InstructionSet.Data[instruction]);

                        if (op != null)
                        {
                            int intValue = 0;
                            if (op.ToString().Contains(","))
                            {
                                intValue += 32768;
                                int indexToBolillo = op.ToString().IndexOf(',');
                                op = op.ToString().Substring(0, indexToBolillo);
                            }
                                

                            if (tabsim.Keys.Contains(op.ToString()))
                            {   // Direccion en tabsim
                                intValue += int.Parse(tabsim[op.ToString()], NumberStyles.HexNumber);
                                objectCode += String.Format("{0:x4}", intValue);
                            }
                            else
                            {   //no encontrado -> 7fff
                                objectCode += "7FFF"; 
                            }
                        }
                        else
                        {
                            if (gridSourceCode.Rows[i].Cells[3].Value.ToString() == "RSUB")
                                objectCode += "0000";
                        }
                    }
                    else
                    {   //es una directiva
                        int intValue = 0;
                        var opStr = op == null? "" : op.ToString();

                        switch (instruction)
                        {
                            case "WORD":
                                if (opStr.Last() == 'H' || opStr.Last() == 'h')
                                {
                                    opStr = opStr.Remove(opStr.Length - 1);
                                    intValue = int.Parse(opStr, NumberStyles.HexNumber);
                                    objectCode = intValue.ToString("000000");
                                } else
                                {
                                    intValue = int.Parse(opStr);
                                    objectCode = string.Format("{0:x6}", intValue);
                                }
                                break;
                            case "BYTE":
                                if(opStr.Contains("C"))
                                {
                                    opStr = opStr.Substring(2, opStr.Length - 3); // Remove C and '

                                    objectCode = "";
                                    foreach(var c in opStr)
                                    {
                                        int value = Convert.ToInt32(c);
                                        // Convert the decimal value to a hexadecimal value in string form.
                                        objectCode += String.Format("{0:X}", value);
                                    }
                                } else
                                {
                                    objectCode = opStr.Substring(2, opStr.Length - 3); // Remove X and '

                                    objectCode += objectCode.Length % 2 == 1 ? "0" : "";
                                }
                                break;
                        }
                    }
                }
                gridSourceCode.Rows[i].Cells[5].Value = objectCode;
            }
        }

        private void GenerateMapMemory()
        {
            gridMapMemory.Rows.Clear();
            startAddr = int.Parse(objFileTextBox.Text.Substring(7, 6),
                NumberStyles.HexNumber);

            length = int.Parse(objFileTextBox.Text.Substring(13, 6),
                NumberStyles.HexNumber);

            endAddr = startAddr + length;

            for (long i = startAddr; i <= endAddr + 16; i += 16)
            {
                String[] data = new String[17];
                data = data.Select(d => "FF").ToArray();
                data[0] = i.ToString("X")
                    .Substring(0, i.ToString("X").Length - 1) // Remove last char
                    .PadLeft(5, '0');

                gridMapMemory.Rows.Add(data);
            }
            Registers["CP"] = int.Parse(objFileTextBox.Text.Substring(objFileTextBox.Text.Count() - 6, 6),
                NumberStyles.HexNumber);
        }

        private void GenerateObjFile()
        {
            string firstInstSaved = "";
            // H section ------------------------
            string programName = gridSourceCode.Rows[0].Cells[2].Value.ToString();
            if(programName.Length > 6)
                programName = programName.Substring(0, 6);
            else
                for (int i = 0; i < 6 - programName.Length; i++)
                    programName += " ";
            objFileTextBox.Text += "H"+ programName + "00" + gridSourceCode.Rows[0].Cells[1].Value.ToString();
            for (int i = 0; i < 6 - progSize.Text.Count(); i++)
                objFileTextBox.Text += "0";
            objFileTextBox.Text += progSize.Text + "\n";

            //T section ---------------------------
            bool newT = true;
            bool firstInstruct = true;
            string dataRegT = "";
            int counterRegT = 0;
            for (int i = 1; i < gridSourceCode.RowCount-2; i++)
            {
                if(gridSourceCode.Rows[i].Cells[3].Value != null &&
                    gridSourceCode.Rows[i].Cells[1].Value.ToString() != 
                    gridSourceCode.Rows[i+1].Cells[1].Value.ToString())
                {
                    string instruction = gridSourceCode.Rows[i].Cells[3].Value.ToString();
                    if ((instruction != "RESW" && instruction != "RESB" && counterRegT < 30))
                    {
                        
                        if(firstInstruct && instruction != "BYTE" && instruction != "WORD")
                        {   //save the first Instr. adrs 
                            firstInstSaved = gridSourceCode.Rows
                                [i].Cells[1].Value.ToString();
                            firstInstruct = false;
                        }
                        if (newT)
                        {
                            objFileTextBox.Text += "T00" + gridSourceCode.Rows
                                [i].Cells[1].Value.ToString();
                            newT = false;
                        }
                        dataRegT += gridSourceCode.Rows
                            [i].Cells[5].Value.ToString();
                        counterRegT += gridSourceCode.Rows[i].Cells[5].Value.ToString().Length / 2;
                    }
                    else
                    {
                        if (counterRegT > 0)
                        {
                            if (String.Format("{0:X}", counterRegT).Length == 1)
                                objFileTextBox.Text += "0" + String.Format("{0:X}", counterRegT);
                            else
                                objFileTextBox.Text += String.Format("{0:X}", counterRegT);
                        }
                        counterRegT = 0;
                        objFileTextBox.Text += dataRegT;
                        dataRegT = "";
                        if (objFileTextBox.Text.Last() != '\n')
                            objFileTextBox.Text += "\n";
                        newT = true;
                    }
                }
            }
            if(dataRegT != "")
            {
                if (counterRegT > 0)
                {
                    if (String.Format("{0:X}", counterRegT).Length == 1)
                        objFileTextBox.Text += "0" + String.Format("{0:X}", counterRegT);
                    else
                        objFileTextBox.Text += String.Format("{0:X}", counterRegT);
                }
                counterRegT = 0;
                objFileTextBox.Text += dataRegT;
                dataRegT = "";
                if (objFileTextBox.Text.Last() != '\n')
                    objFileTextBox.Text += "\n";
            }

            //E section --------------------------------
            objFileTextBox.Text += "E00";
            if (gridSourceCode.Rows[gridSourceCode.RowCount - 2].Cells[4].Value == null)
                objFileTextBox.Text += firstInstSaved;
            else
            {
                if (InstructionSet.Data.ContainsKey(gridSourceCode.Rows
                    [gridSourceCode.RowCount - 2].Cells[4].Value.ToString()))
                {
                    objFileTextBox.Text += InstructionSet.Data[gridSourceCode.Rows
                        [gridSourceCode.RowCount - 2].Cells[4].Value.ToString()];
                }
                else
                {
                    objFileTextBox.Text += "FFFF";
                }
            }
            string name = System.IO.Path.GetFileNameWithoutExtension(CurrentFileName.Text);
            File.WriteAllText(name + ".ob", objFileTextBox.Text);
        }

        private void BtnOpenObj_Click(object sender, EventArgs e)
        {
            canRunObj = true;

            //TOOD cargar archivo
            string [] strOutput = objFileTextBox.Text.Split('\n');
            for (int i = 1; i < strOutput.Count()-1; i++)
            {
                string addrs = strOutput[i].Substring(1, 6); //get current full address
                int len = int.Parse(strOutput[i].Substring(7, 2), NumberStyles.HexNumber); //get lenght 
                string strData = strOutput[i].Substring(9, strOutput[i].Count()-9);

                for (int j = 0; j < len; j++)
                {
                    string row = addrs.Substring(0, 5); //get current addrs row
                    string column = addrs.Substring(5, 1); //get current addrs column

                    // Get DataGridView row that matches the current row value
                    DataGridViewRow selectedRow = gridMapMemory.Rows
                                            .Cast<DataGridViewRow>()
                                            .Where(r => r.Cells[0].Value.ToString().Equals(row))
                                            .First();

                    int intColumValue = int.Parse(column, NumberStyles.HexNumber);
                    selectedRow.Cells[intColumValue + 1].Value = strData.Substring(j * 2, 2);
                    selectedRow.Cells[intColumValue + 1].Style.BackColor = Color.LightSteelBlue;
                    addrs = (int.Parse(addrs, NumberStyles.HexNumber) + 1).ToString("X").PadLeft(6, '0'); //update addrs+1h
                }
            }
        }

        private void btnOpenFrom_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog{};

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFileName.Text = OpenDialog.FileName;
                objFileTextBox.Text = File.ReadAllText(OpenDialog.FileName);
                GenerateMapMemory();
                //BtnOpenObj_Click(sender, e);
            }
        }

        private void btnRunEffect_Click(object sender, EventArgs e)
        {
            if (!canRunObj)
            {
                MessageBox.Show("To run your program first CHARGE OBJ :)");
                return;
            }

            int nLoops = (tbNumLoops.Text == "") ? 1 : int.Parse(tbNumLoops.Text);
            tbNumLoops.Text = "";
            if(Registers["CP"] <= endAddr)
            {
                for (int i = 0; i < nLoops; i++)
                {
                    string operation = Instruction.Map(gridMapMemory, Registers["CP"]);
                    String targetAddrs = Instruction.Map(gridMapMemory, Registers["CP"] + 1) + Instruction.Map(gridMapMemory, Registers["CP"] + 2);
                    int content = int.Parse(targetAddrs, NumberStyles.HexNumber);
                    tbEffects.Text +=  InstructionSet.Effect[int.Parse(operation, NumberStyles.HexNumber)].Effect(gridMapMemory, content);
                    panel1.VerticalScroll.Value = panel1.VerticalScroll.Maximum;
                    UpdateRegGrid();
                }
            }   
        }

        private void AutoRun(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 18)  // CTRL +  r 
                btnRunEffect_Click(sender, e);
        }

        private void UpdateRegGrid ()
        {
            int i = 0;
            foreach (var r in Registers)
            {
                gridRegisters.Rows[i].Cells[1].Value = r.Value.ToString("X").PadLeft(6, '0');
                i++;
            }
        }
    }
}