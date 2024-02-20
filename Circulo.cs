using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Circulo
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro() 
        {
            return 2 * Math.PI * Raio;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nÁrea do círculo: {CalcularArea()}");
            Console.WriteLine($"Perímetro do círculo: {CalcularPerimetro()}");
        }
    }
}
