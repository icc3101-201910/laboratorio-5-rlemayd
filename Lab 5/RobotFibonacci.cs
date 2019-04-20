using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class RobotFibonacci:ICalcular
    {
        public int Calcular(int numero)
        {
            int NFibonacci = 0, NFibonacci1 = 1, NFibonacci2=0, i;
            if (numero == 0)
                return 0;
            else if (numero == 1)
                return 1;
            for (i = 0; i < numero-1; i++)
            {
                NFibonacci2 = NFibonacci + NFibonacci1;
                NFibonacci = NFibonacci1;
                NFibonacci1 = NFibonacci2;
            }
            numero = NFibonacci2;
            return numero;
        }
    }
}
