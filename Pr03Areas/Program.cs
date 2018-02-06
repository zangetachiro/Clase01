using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula el area de un triangulo y la superficie de un circulo
            double area, bas, altura;
            double superficie, radio;
            string resp="";
            Console.Clear();
            Console.WriteLine("La figura es (C)irculo o (T)riangulo");
            resp=Console.ReadLine();
            if (resp.ToUpper() == "C")
            {
                Console.WriteLine("Dame el radio");
                radio = double.Parse(Console.ReadLine());
                superficie = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine("La superficie es {0}", superficie);
            }
            else if (resp.ToUpper() == "T")
            {
                Console.WriteLine("Dame la base");
                bas = double.Parse(Console.ReadLine());
                Console.WriteLine("Dame la altura");
                altura = double.Parse(Console.ReadLine());
                area = (bas * altura) / 2;
                Console.WriteLine("El area es {0}", area);
            }
            else
            {
                Console.WriteLine("Figura desconocida");
            }
        }
    }
}
