using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Triangulo
    {
        public double[] Lados { get; set; }
        public double Area { get; set; }

        public Triangulo(double[] lados)
        {
            Lados = lados;
        }

        public double ValidarTriangulo()
        {
            double a = Lados[0];
            double b = Lados[1];
            double c = Lados[2];

            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2;
                double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine($"Triângulo válido!!\nSua área é: {Area}");
            }
            else
            {
                Console.WriteLine("Triângulo não válido");
            }
            return Area;
        }

        /*Área = √[s(s - a)(s - b)(s - c)]
        Onde "a", "b" e "c" são os comprimentos dos lados do triângulo, e "s" é o semi-perímetro do triângulo
        (s = (a + b + c) / 2).
         
        a + b > c
        a + c > b
        b + c > a
        */

    }
}
