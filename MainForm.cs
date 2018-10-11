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
            public String obj;
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
        }

        private void FillRow(int line, long PC, ParseResult result)
        {
            String[] data =
            {
                    line.ToString(), PC.ToString("X"), result.symbol, result.instruction, result.op, result.obj
            };
            gridSourceCode.Rows.Add(data);
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
                if (!error.Message.Contains("input ' '"))
                {
                    tbErrors.Text += @"Linea " + lineNumber + " con error: " + error.Message;
                    tbErrors.Text += "\r\n";
                    success = false;
                }
            }

            result.parser = parser;
            result.tokens = tokens.GetTokens();
            result.success = success;
            result.num = 40;

            var instructDetected = false;

            foreach (var t in tokens.GetTokens())
            {
                String tokenType = parser.Vocabulary.GetDisplayName(t.Type);

                switch(tokenType)
                {
                    case "INSTRUCCIONES":
                        result.type = "INSTRUCTION";
                        result.instruction = t.Text;
                        instructDetected = true;
                        break;
                    case "TIPODIRECTIVA":
                        result.type = t.Text;
                        result.instruction = t.Text;
                        instructDetected = true;
                        break;
                    case "RSUB":
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
                        result.op = t.Text;
                        if (t.Text.Last() == 'H' || t.Text.Last() == 'h')
                        {
                            uint.TryParse(t.Text.Remove(t.Text.Count() - 1),
                                NumberStyles.HexNumber,
                                CultureInfo.CurrentCulture,
                                out result.num);
                        } else
                        {
                            success = uint.TryParse(t.Text,
                                out result.num);
                        }
                        break;
                    case "ID":
                        if (instructDetected)
                            result.op = t.Text;
                        else
                            result.symbol = t.Text;
                        break;
                }
            }

            return result;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            PCs.Clear();
            // Store program counters of every line

            string contents = File.ReadAllText(CurrentFileName.Text);
            List<String> lines = contents.Replace("\r", " ").Split('\n').ToList();
            tbErrors.Text = "";
            gridSourceCode.Rows.Clear();
            tabsimGrid.Rows.Clear();
            ObjFileTextBox.Text = "";

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
                        case "INSTRUCTION":
                        case "WORD":
                        case "RSUB":
                            PCs.Add(PCs.Last() + 3); break;
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
            GenerateObj();
            GenerateObjFile();
            

            if (tbErrors.Text == "")
                MessageBox.Show("Your grammar rules! ");
            else
                File.WriteAllText("output.txt", tbErrors.Text);

            GenerateMapMemory();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog {
                Filter = "txt files (*.txt)|*.txt|asm files (*.asm)|*.asm",
                FilterIndex = 2
            };

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFileName.Text = OpenDialog.FileName;
                TextBoxEditor.Text = File.ReadAllText(OpenDialog.FileName);
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
                            if (tabsim.Keys.Contains(op.ToString()))
                            {   // Direccion en tabsim
                                int intValue = int.Parse(tabsim[op.ToString()], NumberStyles.HexNumber);
                                //AQUI SUMAR a intValue si es X = 0 o 1 ---
                                objectCode += intValue.ToString("X");
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
            int j = 0;
            for(long i = PCs.First(); i <= PCs.Last(); i+=16)
            {
                String[] data = new String[17];
                data = data.Select(d => "FF").ToArray();
                data[0] = i.ToString("X").Substring(0, i.ToString("X").Length -1 );

                gridMapMemory.Rows.Add(data);
                j++;
            }

            Console.WriteLine(j);
        }

        private void GenerateObjFile()
        {
            string firstInstSaved = "";
            // H section
            string Progname = gridSourceCode.Rows[0].Cells[2].Value.ToString();
            if(Progname.Length > 6)
                Progname = Progname.Substring(0, 6);
            else
                for (int i = 0; i < 6 - Progname.Length; i++)
                    Progname += " ";
            ObjFileTextBox.Text += "H"+ Progname + "00" + gridSourceCode.Rows[0].Cells[1].Value.ToString();
            for (int i = 0; i < 6 - progSize.Text.Count(); i++)
                ObjFileTextBox.Text += "0";
            ObjFileTextBox.Text += progSize.Text.Count() + "\n";

            //T section
            bool newT = true;
            bool FInst = true;
            string TRegisterData = "";
            int TCounter = 0;
            for (int i = 1; i < gridSourceCode.RowCount-2; i++)
            {
                if(gridSourceCode.Rows[i].Cells[3].Value != null &&
                    gridSourceCode.Rows[i].Cells[1].Value.ToString() != 
                    gridSourceCode.Rows[i+1].Cells[1].Value.ToString())
                {
                    string Instruction = gridSourceCode.Rows[i].Cells[3].Value.ToString();
                    if ((Instruction != "RESW" && Instruction != "RESB" && TCounter < 30))
                    {
                        
                        if(FInst && Instruction != "BYTE" && Instruction != "WORD")
                        {   //save the first Instr. adrs 
                            firstInstSaved = gridSourceCode.Rows
                                [i].Cells[1].Value.ToString();
                            FInst = false;
                        }
                        if (newT)
                        {
                            ObjFileTextBox.Text += "T00" + gridSourceCode.Rows
                                [i].Cells[1].Value.ToString();
                            newT = false;
                        }
                        TRegisterData += gridSourceCode.Rows
                            [i].Cells[5].Value.ToString();
                        TCounter += gridSourceCode.Rows[i].Cells[5].Value.ToString().Length / 2;
                    }
                    else
                    {
                        if (TCounter > 0)
                        {
                            if (String.Format("{0:X}", TCounter).Length == 1)
                                ObjFileTextBox.Text += "0" + String.Format("{0:X}", TCounter);
                            else
                                ObjFileTextBox.Text += String.Format("{0:X}", TCounter);
                        }
                        TCounter = 0;
                        ObjFileTextBox.Text += TRegisterData;
                        TRegisterData = "";
                        if (ObjFileTextBox.Text.Last() != '\n')
                            ObjFileTextBox.Text += "\n";
                        newT = true;
                    }
                }
            }
            if(TRegisterData != "")
            {
                if (TCounter > 0)
                {
                    if (String.Format("{0:X}", TCounter).Length == 1)
                        ObjFileTextBox.Text += "0" + String.Format("{0:X}", TCounter);
                    else
                        ObjFileTextBox.Text += String.Format("{0:X}", TCounter);
                }
                TCounter = 0;
                ObjFileTextBox.Text += TRegisterData;
                TRegisterData = "";
                if (ObjFileTextBox.Text.Last() != '\n')
                    ObjFileTextBox.Text += "\n";
            }

            //E section
            ObjFileTextBox.Text += "E00";
            if (gridSourceCode.Rows[gridSourceCode.RowCount - 2].Cells[4].Value == null)
                ObjFileTextBox.Text += firstInstSaved;
            else
            {
                if (InstructionSet.Data.ContainsKey(gridSourceCode.Rows
                    [gridSourceCode.RowCount - 2].Cells[4].Value.ToString()))
                {
                    ObjFileTextBox.Text += InstructionSet.Data[gridSourceCode.Rows
                        [gridSourceCode.RowCount - 2].Cells[4].Value.ToString()];
                }
                else
                {
                    ObjFileTextBox.Text += "FFFF";
                }
            }
            string name = System.IO.Path.GetFileNameWithoutExtension(CurrentFileName.Text);
            File.WriteAllText(name + ".ob", ObjFileTextBox.Text);
        }
    }
}
