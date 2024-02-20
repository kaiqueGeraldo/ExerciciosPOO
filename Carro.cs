using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double VelocidadeAtual { get; set; }
        public double VelocidadeFinal { get; set; }

        public Carro(string marca, string modelo, double velocidadeAtual)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
            VelocidadeFinal = velocidadeAtual;
        }

        public void IniciarControleCarro()
        {
            do
            {
                Console.WriteLine("O que deseja fazer. Acelelar(1); Frear(2); Parar o carro(3)");
                double escolha = Escolha();

                if (escolha == 1)
                {
                    Acelerar();
                }
                else if (escolha == 2)
                {
                    Frear();
                }
                else
                {
                    Console.WriteLine("O carro parou! Velocidade atual: 0Km/h");
                    break;
                }

                Console.WriteLine("Deseja acelerar ou frear novamente?: (S/N)");
                string parar = Console.ReadLine();

                if (!parar.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Parando carro...");
                    break;
                }
            } while (true);

            ExibirInformacoes(VelocidadeFinal);
        }

        private static double Escolha()
        {
            double escolha;
            while (!double.TryParse(Console.ReadLine(), out escolha) || escolha <= 0 || escolha >= 4)
            {
                Console.WriteLine("Escolha inválida. Tente Novamente. Acelelar(1); Frear(2); Parar o carro(3)");
            }
            return escolha;
        }

        private void Acelerar()
        {
            Console.WriteLine("Quanto deseja acelerar?: ");
            double incremento = double.Parse(Console.ReadLine());

            VelocidadeFinal += incremento;

            if (VelocidadeFinal > 0)
            {
                Console.WriteLine($"Ramm!!. Agora o carro está a {VelocidadeFinal} Km/h");
            }
            else
            {
                Console.WriteLine("Você não pode acelerar menos que 0!");
            }
        }

        private void Frear()
        {
            Console.WriteLine("Quanto deseja frear?: ");
            double decremento = double.Parse(Console.ReadLine());

            VelocidadeFinal -= decremento;

            if (VelocidadeFinal > 0)
            {
                Console.WriteLine($"Xii!!. Agora o carro está a {VelocidadeFinal} Km/h");
            }
            else
            {
                Console.WriteLine("Você não pode frear menos que 0!");
            }
        }

        public double ObterValorVelocidadeFim()
        {
            return VelocidadeFinal;
        }

        public void ExibirInformacoes(double velocidadeFinal)
        {
            Console.WriteLine($"\nMarca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Velocidade final: {VelocidadeFinal}Km/h");
        }
    }
}
