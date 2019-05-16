using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOrganizacionFinal.Properties;
using System.IO;
using System.Windows.Forms;

namespace ProyectoOrganizacionFinal.Classes
{
    class AlgoritmoBooth
    {
        Form1 form1 = new Form1();
        public List<string> BoothTable = new List<string>();

        public string result = "";
        string part1 = "", part2 = "";
        public string plusM, minusM;
        char q = '0';
        string space = " ";

      
       
        public string Booth(string bin1, string bin2)
        {
            BoothTable.Add("          Algoritmo Booth          ");
            //form1.TablaBooth.AppendText("\n     BOOTH ALGORITHM:\n");
            //Console.WriteLine("\n     BOOTH ALGORITHM:\n");


            part2 = Complement2.Bin_to_C2(bin2);
            for (int i = 0; i < part2.Length; i++)
            {
                part1 += "0";
            }


            plusM = Complement2.Bin_to_C2(bin1);
            bin1 = (bin1[0] == '+') ? bin1.Remove(0, 1).Insert(0, "-") : bin1.Remove(0, 1).Insert(0, "+");
            minusM = Complement2.Bin_to_C2(bin1);
            BoothTable.Add(" +M = " + plusM + "\n -M = " + minusM + "\n");
            string spaces = new string(' ', part1.Length);
            BoothTable.Add(spaces + "      A" + spaces + "  B   " + "Q    OPERACIONES");

            for (int i = 1; i <= part1.Length; i++)
            {
                if (i >= 10) space = "";

                BoothTable.Add(i + space + ":    " + part1 + "   " + part2 + "   " + q);
                if (part2[part2.Length - 1] == '0' && q == '0')
                    BoothTable.Add("                 " + spaces + spaces + "00 -> SHIFT");
                else if (part2[part2.Length - 1] == '1' && q == '1')
                    BoothTable.Add("                 " + spaces + spaces + "11 -> SHIFT");
                else if (part2[part2.Length - 1] == '1' && q == '0')
                {
                    part1 = Operations.Bin_Add(part1, minusM);
                    BoothTable.Add("      +" + minusM +"          " + spaces + "10 -> +(-M), SHIFT");
                    BoothTable.Add("      =" + part1);
                }
                else if (part2[part2.Length - 1] == '0' && q == '1')
                {
                    part1 = Operations.Bin_Add(part1, plusM);
                    BoothTable.Add("      +" + plusM + "          " + spaces + "01 -> +M, SHIFT");
                    BoothTable.Add("      =" + part1);
                }

                Operations.Shift(ref part1, ref part2, ref q);
            }
            result = part1 + part2;
            BoothTable.Add( "RESULTADO = " + result);
            return result;
        }


     




    }
}
