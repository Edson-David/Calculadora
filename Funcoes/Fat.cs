using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Funcoes
{
    public class Fat
    {
        public static void fatorial(int valor, out int resultado, int aux = 1)
        {
            if (valor >= 1)
            {
                aux *= valor;
                fatorial(valor - 1, out resultado, aux);
            }
            else
            {
                resultado = aux;
            }
        }
    }
}