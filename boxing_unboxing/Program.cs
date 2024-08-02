using System;
using System.Collections.Concurrent;

namespace boxing_unboxing 
{
    class Program
    {
        static void Main(string[] args)
        {

            boxing_unboxing();

        }

        static void boxing_unboxing() 
        
        {
            int numero1 = 20;
            object obj1 = numero1; //boxing
            int resultado = numero1 + (int)obj1; //unboxing
            Console.WriteLine($"La suma de los valores es igual a : {resultado}");


        }


    
    }


}