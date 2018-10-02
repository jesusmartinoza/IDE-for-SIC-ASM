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
        struct ParseResult
        {
            public SicGrammarParser parser;
            public IList<IToken> tokens;
            public String type;
            public uint num;
            public bool success;

            public String symbol;
            public String instruction;
            public String op;
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
        }

        private void fillRow(int line, long PC, ParseResult result)
        {
            String[] data =
            {
                    line.ToString(), PC.ToString("X"), result.symbol, result.instruction, result.op, result.obj
            };
            gridSourceCode.Rows.Add(data);
        }

        private ParseResult parseLine(String line, int lineNumber, String type)
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
                        result.obj += string.Format("{0:x2} ", InstructionSet.Data[t.Text]);
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
            // Store program counters of every line
            var PCs = new List<long>();

            string contents = File.ReadAllText(CurrentFileName.Text);
            List<String> lines = contents.Replace("\r", " ").Split('\n').ToList();
            tbErrors.Text = "";
            gridSourceCode.Rows.Clear();

            // Parse first line
            var result = parseLine(lines[0], 0, "start");
            PCs.Add(result.num);
            fillRow(1, PCs.First(), result);

            // Parse ASM content
            for (int i = 1; i < lines.Count - 1; i++)
            {
                result = parseLine(lines[i], i, "body");

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

                    fillRow(i + 1, PCs[PCs.Count - 2], result);
                } else
                {
                    fillRow(i + 1, PCs.Last(), result);
                }
            }

            // Parse END line
            result = parseLine(lines.Last(), lines.Count, "end");
            fillRow(lines.Count, PCs.Last(), result);

            if (tbErrors.Text == "")
                MessageBox.Show("Your grammar rules! ");
            else
                File.WriteAllText("output.txt", tbErrors.Text);
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

    }
}
