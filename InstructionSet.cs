using System;
using System.Collections.Generic;

namespace IDE_for_SIC_ASM
{
    class InstructionSet
    {
        public static Dictionary<String, int> Data = new Dictionary<String, int>()
        {
            {"ADD", 0x18},
            {"AND", 0x40},
            {"COMP", 0x28},
            {"DIV", 0x24},
            {"J", 0x3C},
            {"JEQ", 0x30},
            {"JGT", 0x34},
            {"JLT", 0x38},
            {"JSUB", 0x48},
            {"LDA", 0x00},
            {"LDCH", 0x50},
            {"LDL", 0x08},
            {"LDX", 0x04},
            {"MUL", 0x20},
            {"OR", 0x44},
            {"RD", 0xD8},
            {"RSUB", 0x4C},
            {"STA", 0x0C},
            {"STCH", 0x54},
            {"STL", 0x14},
            {"STSW", 0xE8},
            {"STX", 0x10},
            {"SUB", 0x1C},
            {"TD", 0xE0},
            {"TIX", 0x2C},
            {"WD", 0xDC}
        };

       public static Dictionary<int, Instruction> Effect = new Dictionary<int, Instruction>()
       {
           {0x18, new Add()},
           {0x40, new And()},
           {0x28, new Comp()},
           {0x24, new Div()},
           {0x3C, new J()},
           {0x30, new Jeq()},
           {0x34, new Jgt()},
           {0x38, new Jlt()},
           {0x48, new Jsub()},
           {0x00, new Lda()},
           {0x50, new Ldch()},
           {0x08, new Ldl()},
           {0x04, new Ldx()},
           {0x20, new Mul()},
           {0x44, new Or()},
           {0xD8, new Rd()},
           {0x4C, new Rsub()},
           {0x0C, new Sta()},
           {0x54, new Stch()},
           {0x14, new Stl()},
           {0xE8, new Stsw()},
           {0x10, new Stx()},
           {0x1C, new Sub()},
           {0xE0, new Td()},
           {0x2C, new Tix()},
           {0xDC, new Wd()}
       };

    }
}
