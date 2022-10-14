using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        
        string x;
        int x1, acumulador;
        acumulador=0;

        Console.WriteLine("ingrese numero");
        x=Console.ReadLine();
        x1=Convert.ToInt32(x);

        acumulador=x1;

        for (int i = x1; i > 1; i--)
        {
            acumulador=acumulador*(i - 1);
            
            
        }
        Console.WriteLine("el factorial de " + x1  + " es " + acumulador);
        }
    }
}
