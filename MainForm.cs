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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            textBox1.Text = "";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string contents = File.ReadAllText(op.FileName);
                string output = "";
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
                        textBox1.Text += @"Linea 1 con error: " + error.Message;
                        textBox1.Text += "\r\n";
                    }
                }

                // Parse ASM content
                for(int i = 1; i < lines.Count - 1; i++)
                {
                    lex = new SicGrammarLexer(new AntlrInputStream(lines[i] + Environment.NewLine));
                    tokens = new CommonTokenStream(lex);
                    parser = new SicGrammarParser(tokens);
                    parser.AddErrorListener(new MyErrorListener());
                    
                    try
                    {
                        parser.proposicion();
                    } catch (Exception error)
                    {
                        if (!error.Message.Contains("input ' '"))
                        {
                            textBox1.Text += @"Linea " + (i+1) + " con error: " + error.Message;
                            textBox1.Text += "\r\n";
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
                        textBox1.Text += @"Linea " + (lines.Count + 1) + " con error: " + error.Message;
                    }
                }

                if (textBox1.Text == "")
                    MessageBox.Show("Your grammar rules! ");
                else
                    File.WriteAllText("output.txt", textBox1.Text);
            }
        }
    }
}
