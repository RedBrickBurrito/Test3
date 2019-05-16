using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo1_Resolver
{
    public class GIS
    {
        public static void insertionSort<T>(ref T[] arr, int n) where T: IComparable 
        {
          
            int i,j;
            T key;

            
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

        }

      
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            GIS g = new GIS();
            GIS.insertionSort<char>(, 1);
            
        }
    }
}
