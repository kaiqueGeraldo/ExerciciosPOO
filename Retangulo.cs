using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalcularArea()
        {
            return Altura * Largura;
        }
        
        public double CalcularPerimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }

        public void ExibirInformacoes() 
        {
            Console.WriteLine($"\nÁrea do retângulo: {CalcularArea()}");
            Console.WriteLine($"Perimetro do retângulo: {CalcularPerimetro()}");
        }
    }
}
