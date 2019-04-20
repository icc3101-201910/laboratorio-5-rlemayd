using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class PerroFactorial:ICalcular
    {
        int numFact = 1;

        public int Calcular(int numero)
        {
            while (numero > 0)
            {
                numFact *= numero;
                numero -= 1;
            }
            numero = numFact;
            return numero;
        }
    }
}
