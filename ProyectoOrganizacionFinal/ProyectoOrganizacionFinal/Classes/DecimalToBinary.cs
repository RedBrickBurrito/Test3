using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrganizacionFinal.Classes
{
    class DecimalToBinary
    {
        public static string Dec_to_bin(int dec)
        {
            string bin = "";
            bool finished = false;
            bool minus = false;
            char holder;

            if (dec < 0)
            {
                dec *= -1;
                minus = true;
            }

            while (!finished)
            {
                bin += (dec % 2 == 1) ? '1' : '0';
                dec /= 2;
                finished = (dec == 0) ? true : false;
            }

            for (int i = 0; i < (bin.Length) / 2; i++)
            {
                holder = bin[i];
                bin = bin.Remove(i, 1).Insert(i, Convert.ToString(bin[bin.Length - 1 - i]));
                bin = bin.Remove(bin.Length - 1 - i, 1).Insert(bin.Length - 1 - i, Convert.ToString(holder));
            }

            bin = (minus) ? "-" + bin : "+" + bin;

            return bin;
        }
    }
}
