﻿using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” 
            //si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
          

            int n;

            Console.WriteLine("ingrese número : ");
            n = int.Parse(Console.ReadLine());

            if (n>0)
            {Console.WriteLine("Positivo");
                
            }else if (n<0)
            {Console.WriteLine("Negativo");
                
                }else
                {Console.WriteLine("Cero");
                
            }

            Console.WriteLine("Fin del Programa");




























        }
    }
}
