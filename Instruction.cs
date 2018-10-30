using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_for_SIC_ASM
{
    abstract class Instruction
    {
        public abstract String Effect(DataGridView mapMemory, int m);

        public String Map(DataGridView mapMemory, int m)
        {
            String row = m.ToString().Substring(0, m.ToString().Count() - 1);
            String column = m.ToString().Substring(m.ToString().Count() - 1, 1);

            // Get DataGridView row that matches the current row value
            DataGridViewRow selectedRow = mapMemory.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells[0].Value.ToString().Equals(row))
                                    .First();

            int intColumValue = int.Parse(column, NumberStyles.HexNumber);

            return selectedRow.Cells[intColumValue + 1].Value.ToString();
        }

    }

    class Add : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
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
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] &= int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
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
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Div : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class J : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jeq : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jgt : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jlt : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Jsub : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Lda : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
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
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Ldl : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Ldx : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Mul : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Or : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Rd : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Rsub : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Sta : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stch : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stl : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stsw : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Stx : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Sub : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Td : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
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
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }

    class Wd : Instruction
    {
        public override String Effect(DataGridView mapMemory, int m)
        {
            // Get DataGridView row that matches the current row value
            String output = "\n CP: " + MainForm.Registers["CP"].ToString("XXXXXX");
            String content = Map(mapMemory, m) + Map(mapMemory, m + 1) + Map(mapMemory, m + 2);

            MainForm.Registers["A"] += int.Parse(content, NumberStyles.HexNumber);
            MainForm.Registers["CP"] += 3;

            output += " => " + MainForm.Registers["CP"].ToString("XXXXXX");
            output += "\n Operator: ADD";
            output += "\n Effect: A <- " + content;
            output += "\n-----------------------------\n";

            return output;
        }
    }
}
