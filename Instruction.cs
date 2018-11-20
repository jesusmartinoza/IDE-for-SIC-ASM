using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_for_SIC_ASM
{
    abstract class Instruction
    {
        public static bool isIndex;
        public abstract String Effect(DataGridView mapMemory, int m);

        public static String Map(DataGridView mapMemory, int m)
        {
            isIndex = false;
            if(m> 32768) {
                m -= 32768;
                isIndex = true;
                m += MainForm.Registers["X"];
            }
            
            String addrs = m.ToString("X").PadLeft(6, '0');
            String row = addrs.ToString().Substring(0, addrs.ToString().Count() - 1);
            String column = addrs.ToString().Substring(addrs.ToString().Count() - 1, 1);

            // Get DataGridView row that matches the current row value
            DataGridViewRow selectedRow = mapMemory.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[0].Value.ToString().Equals(row))
                                    .First();

            int intColumValue = int.Parse(column, NumberStyles.HexNumber);

            return selectedRow.Cells[intColumValue + 1].Value.ToString();
        }

        public int ReplaceRight(int a, int b)
        {
            String aStr = a.ToString("X").PadLeft(6, '0');
            String bStr = b.ToString("X").PadLeft(6, '0');

            // Remove last 2 char
            aStr = aStr.Substring(0, 4);

            // Add last 2 chars of b
            aStr += bStr.Substring(4, 2);

            return int.Parse(aStr, NumberStyles.HexNumber);
        }

        public void ReplaceMapMemory(DataGridView mapMemory, int m, int num, int nLoops)
        {
            isIndex = false;
            if (m > 32768)
            {
                m -= 32768;
                m += MainForm.Registers["X"];
            }

            String addrs = m.ToString("X").PadLeft(6, '0');
            String row = addrs.ToString().Substring(0, addrs.ToString().Count() - 1);
            String column = addrs.ToString().Substring(addrs.ToString().Count() - 1, 1);
            String numStr = num.ToString("X").PadLeft(6, '0');

            DataGridViewRow selectedRow = mapMemory.Rows
                                          .Cast<DataGridViewRow>()
                                          .Where(r => r.Cells[0].Value.ToString().Equals(row))
                                          .First();

            int intColumValue = int.Parse(column, NumberStyles.HexNumber);
            if (nLoops == 1)
                numStr = numStr.Substring(4, 2);// new string(numStr.Reverse().ToArray());

            for (var i = 0; i < nLoops; i++)
            {
                selectedRow.Cells[intColumValue + 1 + i].Value = numStr.Substring(i * 2, 2);
                selectedRow.Cells[intColumValue + 1 + i].Style.BackColor = Color.Yellow;
            }
        }
    }

    class Add : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: ADD";
            output += "\n Effect: A <- (A) +" + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class And : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] &= int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: AND";
            output += "\n Effect: A <- (A) & " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Comp : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);
            int num = int.Parse(content, NumberStyles.HexNumber);

            if (MainForm.Registers["A"] > num)
                MainForm.Registers["SW"] = 1;
            else if (MainForm.Registers["A"] == num)
                MainForm.Registers["SW"] = 0;
            else
                MainForm.Registers["SW"] = -1;

            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: COMP";
            output += "\n Effect: (A) : " + content;
            output += "\n SW = " + MainForm.Registers["SW"];
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Div : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] /= int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: DIV";
            output += "\n Effect: A <- (A) / " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class J : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');

            MainForm.Registers["CP"] = m;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: J";
            output += "\n Effect: CP <- " + m.ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jeq : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            MainForm.Registers["CP"] += 3;

            if (MainForm.Registers["SW"] == 0)
            {
                MainForm.Registers["CP"] = m;
            }

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: JEQ";
            output += "\n Effect: CP <- " + MainForm.Registers["CP"].ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jgt : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            MainForm.Registers["CP"] += 3;

            if (MainForm.Registers["SW"] == 1)
            {
                MainForm.Registers["CP"] = m;
            }

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: JGT";
            output += "\n Effect: CP <- " + MainForm.Registers["CP"].ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jlt : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            MainForm.Registers["CP"] += 3;

            if (MainForm.Registers["SW"] == -1)
            {
                MainForm.Registers["CP"] = m;
            }
            

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: JLT";
            output += "\n Effect: CP <- " + MainForm.Registers["CP"].ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jsub : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["L"] = MainForm.Registers["CP"];
            MainForm.Registers["CP"] = int.Parse(content, NumberStyles.HexNumber);

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: JSUB";
            output += "\n Effect: L <- (" + MainForm.Registers["L"].ToString("X") + ")";
            output += "\n\t CP <- (" + content + ")";
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Lda : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] = int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: LDA";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Ldch : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            int content = int.Parse(Map(mapMemory, m), NumberStyles.HexNumber);

            MainForm.Registers["A"] = ReplaceRight(MainForm.Registers["A"], content);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: LDCH";
            output += "\n Effect: A[byte mas a la derecha] <- " + content.ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Ldl : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["L"] = int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: LDL";
            output += "\n Effect: L <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Ldx : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["X"] = int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: LDX";
            output += "\n Effect: X <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Mul : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] *= int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: MUL";
            output += "\n Effect: A <- (A) * " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Or : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] |= int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: OR";
            output += "\n Effect: A <- (A) | " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Rd : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            int content = int.Parse(Map(mapMemory, m), NumberStyles.HexNumber);

            MainForm.Registers["A"] = ReplaceRight(MainForm.Registers["A"], content);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: RD";
            output += "\n Effect: A[byte mas a la derecha] <- no sabemos profe :) " + content.ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Rsub : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');

            MainForm.Registers["CP"] = MainForm.Registers["L"];

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: RSUB";
            output += "\n Effect: CP <- " + MainForm.Registers["L"].ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Sta : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            ReplaceMapMemory(mapMemory, m, MainForm.Registers["A"], 3);
            MainForm.Registers["CP"] += 3;

            if (m > 32768)
            {
                m -= 32768;
                isIndex = true;
                m += MainForm.Registers["X"];

            }
            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: STA";
            output += "\n Effect: " + m.ToString("X") + " <- " + MainForm.Registers["A"].ToString("X").PadLeft(6, '0');
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stch : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            // TODO: Hacer bien este efecto
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            ReplaceMapMemory(mapMemory, m, MainForm.Registers["A"], 1);
            MainForm.Registers["CP"] += 3;

            if (m > 32768)
            {
                m -= 32768;
                isIndex = true;
                m += MainForm.Registers["X"];
            }

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: STCH";
            output += "\n Effect: " + m.ToString("X") + " <- " + MainForm.Registers["A"].ToString("X").PadLeft(6, '0');
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stl : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            ReplaceMapMemory(mapMemory, m, MainForm.Registers["L"], 3);
            MainForm.Registers["CP"] += 3;
            if (m > 32768)
            {
                m -= 32768;
                isIndex = true;
                m += MainForm.Registers["X"];

            }

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: STL";
            output += "\n Effect: " + m.ToString("X")  + " <- " + MainForm.Registers["L"].ToString("X").PadLeft(6, '0');
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stsw : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            ReplaceMapMemory(mapMemory, m, MainForm.Registers["SW"], 3);
            MainForm.Registers["CP"] += 3;

            if (m > 32768)
            {
                m -= 32768;
                isIndex = true;
                m += MainForm.Registers["X"];

            }

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: STSW";
            output += "\n Effect: " + m.ToString("X")  + " <- " + MainForm.Registers["SW"].ToString("X").PadLeft(6, '0');
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stx : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            ReplaceMapMemory(mapMemory, m, MainForm.Registers["X"], 3);
            MainForm.Registers["CP"] += 3;
            if (m > 32768)
            {
                m -= 32768;
                isIndex = true;
                m += MainForm.Registers["X"];

            }

            output += " => " + MainForm.Registers["X"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: STX";
            output += "\n Effect: " + m.ToString("X")  + " <- " + MainForm.Registers["X"].ToString("X").PadLeft(6, '0');
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Sub : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] -= int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: SUB";
            output += "\n Effect: A <- (A) - " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Td : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            // TODO: Completar chido esta funcion
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Tix : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);
            int num = int.Parse(content, NumberStyles.HexNumber);

            MainForm.Registers["X"]++;

            if (MainForm.Registers["X"] > num)
                MainForm.Registers["SW"] = 1;
            else if (MainForm.Registers["X"] == num)
                MainForm.Registers["SW"] = 0;
            else
                MainForm.Registers["SW"] = -1;

            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: TIX";
            output += "\n Effect: X <- " + MainForm.Registers["X"].ToString("X") + "; (X) : " + content;
            output += "\n SW = " + MainForm.Registers["SW"].ToString("X");
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Wd : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            // TODO: Implementar chido
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("X").PadLeft(6, '0');
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }
}