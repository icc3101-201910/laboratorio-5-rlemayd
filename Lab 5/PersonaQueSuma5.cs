using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class PersonaQueSuma5:ICalcular
    {
        public int Calcular(int numero)
        {
            numero += 5;
            return numero;
        }        
    }
}
