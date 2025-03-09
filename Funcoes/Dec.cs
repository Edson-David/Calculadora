using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Funcoes
{
    public class Dec
    {
        public static string DecToBin(int valor)
        {
            int div, mod;
            string bit;

            mod = valor % 2;
            div = (valor - mod) / 2;
            bit = mod.ToString();

            if (div > 1)
            {
                return DecToBin(div) + bit;
            }
            else if (div > 0)
            {
                return div + bit;
            }
            else
            {
                return bit;
            }
        }
    }
}