using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_for_SIC_ASM
{
    class MyParseListener : SicGrammarBaseListener
    {
        public void ExitEveryRule(SicGrammarParser.ProposicionContext context)
        {
            Console.WriteLine("AafasfsA");
        }
    }
}
