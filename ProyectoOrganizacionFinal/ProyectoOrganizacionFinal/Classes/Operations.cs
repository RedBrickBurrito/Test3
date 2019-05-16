using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrganizacionFinal.Classes
{
    class Operations
    {
        public static string Bin_Add(string bin1, string bin2)
        {
            string result = "";
            char moved = '0';
            for (int i = bin1.Length - 1; i >= 0; i--)
                result += "x";

            for (int i = bin1.Length - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(Char.GetNumericValue(bin1[i])) + Convert.ToInt32(Char.GetNumericValue(bin2[i]))
                    + Convert.ToInt32(Char.GetNumericValue(moved)) == 3)
                {
                    result = result.Remove(i, 1).Insert(i, "1");
                    moved = '1';
                }
                else if (Convert.ToInt32(Char.GetNumericValue(bin1[i])) + Convert.ToInt32(Char.GetNumericValue(bin2[i]))
                    + Convert.ToInt32(Char.GetNumericValue(moved)) == 2)
                {
                    result = result.Remove(i, 1).Insert(i, "0");
                    moved = '1';
                }
                else if (Convert.ToInt32(Char.GetNumericValue(bin1[i])) + Convert.ToInt32(Char.GetNumericValue(bin2[i]))
                    + Convert.ToInt32(Char.GetNumericValue(moved)) == 1)
                {
                    result = result.Remove(i, 1).Insert(i, "1");
                    moved = '0';
                }
                else if (Convert.ToInt32(Char.GetNumericValue(bin1[i])) + Convert.ToInt32(Char.GetNumericValue(bin2[i]))
                    + Convert.ToInt32(Char.GetNumericValue(moved)) == 0)
                {
                    result = result.Remove(i, 1).Insert(i, "0");
                    moved = '0';
                }
            }
            return result;
        }

        public static void Shift(ref string p1, ref string p2, ref char q)
        {
            q = p2[p2.Length - 1];
            for (int i = p2.Length - 1; i >= 1; i--)
                p2 = p2.Remove(i, 1).Insert(i, Convert.ToString(p2[i - 1]));
            p2 = p2.Remove(0, 1).Insert(0, Convert.ToString(p1[p1.Length - 1]));

            for (int i = p1.Length - 1; i >= 1; i--)
                p1 = p1.Remove(i, 1).Insert(i, Convert.ToString(p1[i - 1]));
        }

    }
}
