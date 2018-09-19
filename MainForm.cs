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

namespace IDE_for_SIC_ASM
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            // Configuracion de Material Theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Blue100, Accent.Yellow400, TextShade.WHITE);

            BackColor = Color.FromArgb(66, 66, 80);
            //numberLabel.Font = new Font(TextBoxEditor.Font.FontFamily,
            //                  TextBoxEditor.Font.Size);
            numberLabel.Location = new Point(1, TextBoxEditor.Location.Y+2);

            UpdateNumberLabel();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            tbErrors.Text = "";
            string contents = File.ReadAllText(CurrentFileName.Text);
            List<String> lines = contents.Replace("\r", " ").Split('\n').ToList();

            // Parse first line
            SicGrammarLexer lex = new SicGrammarLexer(new AntlrInputStream(lines[0] + Environment.NewLine));
            CommonTokenStream tokens = new CommonTokenStream(lex);
            SicGrammarParser parser = new SicGrammarParser(tokens);
            parser.AddErrorListener(new MyErrorListener());

            try
            {
                parser.inicio();
            }
            catch (Exception error)
            {
                if (!error.Message.Contains("input ' '"))
                {
                    tbErrors.Text += @"Linea 1 con error: " + error.Message;
                    tbErrors.Text += "\r\n";
                }
            }

            // Parse ASM content
            for (int i = 1; i < lines.Count - 1; i++)
            {
                lex = new SicGrammarLexer(new AntlrInputStream(lines[i] + Environment.NewLine));
                tokens = new CommonTokenStream(lex);
                parser = new SicGrammarParser(tokens);
                parser.AddErrorListener(new MyErrorListener());

                try
                {
                    parser.proposicion();
                }
                catch (Exception error)
                {
                    if (!error.Message.Contains("input ' '"))
                    {
                        tbErrors.Text += @"Linea " + (i + 1) + " con error: " + error.Message;
                        tbErrors.Text += "\r\n";
                    }
                }
            }

            // Parse END line
            lex = new SicGrammarLexer(new AntlrInputStream(lines.Last() + Environment.NewLine));
            tokens = new CommonTokenStream(lex);
            parser = new SicGrammarParser(tokens);
            parser.AddErrorListener(new MyErrorListener());

            try
            {
                parser.fin();
            }
            catch (Exception error)
            {
                if (!error.Message.Contains("input ' '"))
                {
                    tbErrors.Text += @"Linea " + (lines.Count + 1) + " con error: " + error.Message;
                }
            }

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

        private void UpdateNumberLabel()
        {
            //we get index of first visible char and 
            //number of first visible line
            Point pos = new Point(0, 0);
            int firstIndex = TextBoxEditor.GetCharIndexFromPosition(pos);
            int firstLine = TextBoxEditor.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char 
            //and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = TextBoxEditor.GetCharIndexFromPosition(pos);
            int lastLine = TextBoxEditor.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll 
            //use its Y value for calculating numberLabel size
            pos = TextBoxEditor.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }
        }

        private void TextBoxEditor_VScroll(object sender, EventArgs e)
        {
           UpdateNumberLabel();
        }

        private void TextBoxEditor_TextChanged(object sender, EventArgs e)
        {
            UpdateNumberLabel();
        }
    }
}
