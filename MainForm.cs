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

            test();
        }

        /**
        * Calculate and evalute using ANTLR magic
        */
        private void test()
        {
            string line = "SUM    START    4000H\n FIRST LDX ZERO\n LDA ZERO\n END";
            SicGrammarLexer lex = new SicGrammarLexer(new AntlrInputStream(line + Environment.NewLine));
            //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
            CommonTokenStream tokens = new CommonTokenStream(lex);
            //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
            SicGrammarParser parser = new SicGrammarParser(tokens);
            //CREAMOS EL PARSER CON LOS TOKENS CREADOS
            parser.programa();
        }
    }
}
