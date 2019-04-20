using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Calculadora
    {
        int numero;
        public List<ICalcular> calculadoras;
        PersonaQueSuma5 PersonaQueSuma5 = new PersonaQueSuma5();
        RobotFibonacci RobotFibonacci = new RobotFibonacci();
        PerroFactorial PerroFactorial = new PerroFactorial();
        Cubo Cubo= new Cubo();
        Cuadrado Cuadrado = new Cuadrado();
        Random random = new Random();



        public Calculadora (int numero)
        {
            //Creamos la lista calculadoras, la cual contiene todas las funciones
            calculadoras = new List<ICalcular>() { PersonaQueSuma5, RobotFibonacci, PerroFactorial, Cubo, Cuadrado};
            this.numero = numero;
        }
        

        public void Calcular(int operacion)
        {
            int x = random.Next(0, 4);

            //Para parte 3: Menu
            if (operacion == 6) // Le ponemos ==6 , para que sepa que es la parte 3 (Realizar operaciones aleatoriamente)
            {
                if (calculadoras[x] == PersonaQueSuma5) //Para cuando entre a la funcion solicitada
                {
                    Console.WriteLine($"Haciendo la operacion PersonaQueSuma5 a {numero} se obtiene: ");
                    numero = PersonaQueSuma5.Calcular(numero); // Guardamos el nuevo valor de "numero" (tras realizar la operacion)
                }


                else if (calculadoras[x] == RobotFibonacci)
                {
                    Console.WriteLine($"Haciendo la operacion RobotFibonacci a {numero} se obtiene: ");
                    numero = RobotFibonacci.Calcular(numero);

                }

                else if (calculadoras[x] == PerroFactorial)
                {
                    Console.WriteLine($"Haciendo la operacion PerroFactorial a {numero} se obtiene: ");
                    numero = PerroFactorial.Calcular(numero);
                }

                else if (calculadoras[x] == Cubo)
                {
                    Console.WriteLine($"Haciendo la operacion Cubo a {numero} se obtiene: ");
                    numero = Cubo.Calcular(numero);
                }

                else                                             
                {
                    Console.WriteLine($"Haciendo la operacion Cubo a {numero} se obtiene: ");
                    numero = Cuadrado.Calcular(numero);
                }
            }

            //Para parte 4: Bonus
            else if (operacion < 5)  //Para cuando se quiere utilizar la parte 4, escogieno la operacion deseada
            {
                if (calculadoras[operacion] == PersonaQueSuma5)
                {
                    Console.WriteLine($"Haciendo la operacion PersonaQueSuma5 a {numero} se obtiene: ");
                    numero = PersonaQueSuma5.Calcular(numero);
                }


                else if (calculadoras[operacion] == RobotFibonacci)
                {
                    Console.WriteLine($"Haciendo la operacion RobotFibonacci a {numero} se obtiene: ");
                    numero = RobotFibonacci.Calcular(numero);

                }

                else if (calculadoras[operacion] == PerroFactorial)
                {
                    Console.WriteLine($"Haciendo la operacion PerroFactorial a {numero} se obtiene: ");
                    numero = PerroFactorial.Calcular(numero);
                }

                else if (calculadoras[operacion] == Cubo)
                {
                    Console.WriteLine($"Haciendo la operacion Cubo a {numero} se obtiene: ");
                    numero = Cubo.Calcular(numero);
                }
                
                else                                             //Asumiendo que se entregaran valores solo entre esas opciones
                {
                    Console.WriteLine($"Haciendo la operacion Cubo a {numero} se obtiene: ");
                    numero = Cuadrado.Calcular(numero);
                }
            }

            


        }
        
        public int GetMetodo()
        {
            return numero;
        }
    }
}
