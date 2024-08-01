using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Révision
{
    internal class Stat
    {
        static void Main(string[] args)
        {
            int nbElement, occ = 5;
            int s = Somme(out nbElement, ref occ, 1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine($"Somme={s},NbElement= {nbElement} ,NbOccurence = {occ}");
        }

        public static int Somme(out int n, ref int m, params int[] T)
        // n == par le parametre donc variable de sortie
        // m==

        {
            int s = 0;
            int nbval = 0;
            n = T.Length;
            foreach (int i in T)
            {
                s += i;
                if (i == m)
                    nbval++;
            }
            m = nbval;
            return s;
        }
    }
    }

