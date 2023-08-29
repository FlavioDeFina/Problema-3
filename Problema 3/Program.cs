using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float cp1, cp2, cp3, cef, ctf, nf;
            Console.WriteLine("Ingrese su Primera Calificación Parcial: ");
            cp1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su Segunda Calificación Parcial: ");
            cp2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su Tercera Calificación Parcial: ");
            cp3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su Calificación del examen final: ");
            cef = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese su Calificación del trabajo final: ");
            ctf = Convert.ToSingle(Console.ReadLine());
            nf = 0.55f * (cp1 + cp2 + cp3) / 3 + 0.30f * cef + 0.15f * ctf;
            Console.WriteLine("El promedio final es: " + nf.ToString("0.00"));
            Console.ReadKey();

        }
    }
}
