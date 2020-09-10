using System;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {

            float nota1, nota2, nota3, promedio;
            String linea;
                 Console.WriteLine("Digite la nota 1");
            linea = Console.ReadLine();

            nota1 = float.Parse(linea);
            Console.WriteLine("Digite la nota 2");
            linea = Console.ReadLine();

            nota2 = float.Parse(linea);
            Console.WriteLine("Digite la nota 3");
            linea = Console.ReadLine();

            nota3 = float.Parse(linea);

            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio < 3)
            {
                Console.WriteLine("REPROBO su Promedio es " + promedio);

            }
            else if (promedio >= 3)
            {
                Console.WriteLine("APROBO su Promedio es " + promedio);

            }
            Console.ReadLine();

        }
    }
    }
