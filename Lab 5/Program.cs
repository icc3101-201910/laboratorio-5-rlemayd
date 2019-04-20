using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroIngresado;
            int NumeroDeOperaciones;
            int Operacion;
            Random random = new Random();

            // Para escoger que queremos que haga nuestro programa
            Console.WriteLine("[0] Menu (operaciones aleatorias)");
            Console.WriteLine("[1] Bonus (Escoger que operacion realizar)");
            Console.WriteLine("Ingrese que opcion quiere realizar:");
            int inicio = Convert.ToInt32(Console.ReadLine());

            if (inicio == 0)         //PARTE 3: MENU
            {
                Console.WriteLine("\nIngrese el número con el que desea partir calculando");
                NumeroIngresado = Convert.ToInt32(Console.ReadLine());      // Guarda el numero con el que se partira calculando
                Calculadora calculadora = new Calculadora(NumeroIngresado);

                Console.WriteLine("ingrese el número de cálculos a realizar");   // Guarda cuantas operaciones queremos realizar
                NumeroDeOperaciones = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (int i = 0; i < NumeroDeOperaciones; i++)
                {
                    calculadora.Calcular(6);
                    Console.WriteLine(calculadora.GetMetodo() + "\n");
                }
            }

            else if (inicio == 1)           //PARTE 4: BONUS 
            {
                Console.WriteLine("\n[0] PersonaQueSuma5");
                Console.WriteLine("[1] RobotFibonacci");
                Console.WriteLine("[2] PerroFactorial");
                Console.WriteLine("[3] Cubo");
                Console.WriteLine("[4] Cuadrado");
                Console.WriteLine("Ingrese la operacion que desea realizar: ");
                Operacion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIngrese el número con el que desea partir calculando");
                NumeroIngresado = Convert.ToInt32(Console.ReadLine());

                Calculadora calculadora1 = new Calculadora(NumeroIngresado);
                calculadora1.Calcular(Operacion);                                 // Realizamos la operacion
                Console.WriteLine(calculadora1.GetMetodo());                      // Obtenemos el resultado de la operacion
            }

            

            


            Console.ReadKey();


        }
    }
}
