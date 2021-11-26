using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_somaarea_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string area;
            Console.WriteLine("IMFORME A FORMA GEOMETRICA" + "\n 1:QUADRADO" + "\n2:RETANGULO" + "\n3:TRAPEZIO" + "\n4:LOSANGULO");
            area = Console.ReadLine().ToUpper();

            switch (area)

            {
                case "1":

                    Console.WriteLine("\nIMFORME O LADO DO QUADRADO: ");

                    double lado = double.Parse(Console.ReadLine());

                     double area1 = lado * lado;

                    Console.WriteLine("A AREA DO QUADRADO É DE " + area1);
                    break;

                case "2":

                    Console.WriteLine("\nIMFORME A BASE  DO RETANGULAO: ");

                    double bas = double.Parse(Console.ReadLine());

                    Console.WriteLine("IMFORME A ALTURA  DO RETANGULO: ");

                    double altura = double.Parse(Console.ReadLine());

                    area1 = bas * altura;

                    Console.WriteLine("A AREA DO QUADRADO É DE " + area1);
                    break;

                case "3":

                    Console.WriteLine("\nIMFORME A BASE MENOR : ");

                    double basmenor = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nIMFORME A BASE MAIOR : ");

                    double basmaior = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nIMFORME A  ALTURA : ");

                    altura = double.Parse(Console.ReadLine());

                    area1 = (basmaior + basmenor)*(altura)/2;

                    Console.WriteLine("A AREA DO TRAPEZIO É DE " + area1);
                    break;

                case "4":

                    Console.WriteLine("\nIMFORME A MEDIDA DIAGONAL 1 : ");

                    double dia1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nIMFORME A  MEDIDA DAGONAL 2: ");

                    double dia2 = double.Parse(Console.ReadLine());

                    area1 = (dia1 * dia2) / 2;

                    Console.WriteLine("A AREA DO LOSANGULO É DE " + area1);
                    break;


            }


            Console.ReadKey();
        }
    }
}
