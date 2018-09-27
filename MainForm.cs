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

namespace IDE_for_SIC_ASM
{
    public partial class MainForm : MaterialForm
    {
        struct ParseResult
        {
            public SicGrammarParser parser;
            public IList<IToken> tokens;
            public String type;
            public int num;
            public bool success;
        }

        public MainForm()
        {
            InitializeComponent();
            // Configuracion de Material Theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Blue100, Accent.Yellow400, TextShade.WHITE);

            TextBoxEditor.BackColor = Color.FromArgb(43, 43, 43);
            TextBoxEditor.ForeColor = Color.FromArgb(169, 183, 197);
            TextBoxEditor.CaretColor = Color.FromArgb(169, 183, 197);


            panel1.BackColor = Color.FromArgb(49, 64, 74);
            //BackColor = Color.FromArgb(66, 66, 80);
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
            
            foreach (var t in tokens.GetTokens())
            {
                String tokenType = parser.Vocabulary.GetDisplayName(t.Type);

                if (tokenType.Equals("INSTRUCCIONES"))
                    result.type = "INSTRUCTION";
                if (tokenType.Equals("TIPODIRECTIVA"))
                    result.type = t.Text;
            }


            return result;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            // Store program counters of every line
            var PCs = new List<int>();
            PCs.Add(0); // TODO: Direccion carga 

            string contents = File.ReadAllText(CurrentFileName.Text);
            List<String> lines = contents.Replace("\r", " ").Split('\n').ToList();
            tbErrors.Text = "";

            // Parse first line
            parseLine(lines[0], 0, "start");
           
            // Parse ASM content
            for (int i = 1; i < lines.Count - 1; i++)
            {
                var result = parseLine(lines[i], i, "body");

                switch(result.type)
                {
                    case "INSTRUCTION": PCs.Add(PCs.Last() + 3); break;
                    case "WORD": PCs.Add(PCs.Last() + 3); break;
                    //case "byte": PCs.Add(PCs.Last() + result.byteSize); break;
                    case "RESB": PCs.Add(PCs.Last() + result.num); break;
                    case "RESW": PCs.Add(PCs.Last() + result.num * 3); break;
                }
            }

            // Parse END line
            parseLine(lines.Last(), lines.Count, "end");

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
