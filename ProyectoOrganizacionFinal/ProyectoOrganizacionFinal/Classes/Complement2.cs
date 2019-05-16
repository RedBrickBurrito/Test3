using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrganizacionFinal.Classes
{
    class Complement2
    {
        public static string Bin_to_C2(string bin)
        {
            if (bin[0] == '+')
                bin = bin.Remove(0, 1).Insert(0, "0");
            else
            {
                bin = bin.Remove(0, 1).Insert(0, "0");
                for (int i = 0; i < bin.Length; i++)
                    bin = (bin[i] == '1') ? bin.Remove(i, 1).Insert(i, "0") : bin.Remove(i, 1).Insert(i, "1");

                for (int i = bin.Length - 1; i >= 0; i--)
                {
                    bin = (bin[i] == '1') ? bin.Remove(i, 1).Insert(i, "0") : bin.Remove(i, 1).Insert(i, "1");
                    if (bin[i] == '1')
                        break;
                }
            }

            return bin;
        }

        public static int C2_to_dec(string C2)
        {
            int dec = 0;

            dec -= Convert.ToInt32(Char.GetNumericValue(C2[0])) * Convert.ToInt32(Math.Pow(2, Convert.ToDouble(C2.Length - 1)));

            for (int i = 1; i <= C2.Length - 1; i++)
                dec += Convert.ToInt32(Char.GetNumericValue(C2[i])) * Convert.ToInt32(Math.Pow(2, Convert.ToDouble(C2.Length - 1 - i)));

            return dec;
        }
    }
}
