﻿using System;

namespace ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int cantidad,precio;
            float monto;

            Console.WriteLine("ingrese el precio :");
            precio=int.Parse(Console.ReadLine());
        
            Console.WriteLine("ingrese la cantidad :");
            cantidad= int.Parse(Console.ReadLine());

            monto = producto(precio,cantidad);

            Console.WriteLine("el monto a pagar es de :" + monto);
                     
        


        }
        

        static int producto(int a ,int b)
        {
            int r;

            r= a*b;
            
            return r;

        }
    }
}
