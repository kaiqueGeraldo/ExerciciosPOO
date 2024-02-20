using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public double Impostos { get; set; }
        public string OuveBeneficios { get; set; }
        public double ValorBeneficio { get; set; }


        public Funcionario()
        {
        }
        public Funcionario(string nome, double salario, string cargo, double impostos, string beneficios, double valorBeneficio)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
            Impostos = impostos;
            OuveBeneficios = beneficios;
            ValorBeneficio = valorBeneficio;
        }

        public void OuveBeneficio(string beneficio)
        {
            if (!beneficio.Equals("S", StringComparison.CurrentCultureIgnoreCase))
            {

            }
            else
            {
                Console.WriteLine("Qual o valor do benefício?: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    Salario += valor;
                    Console.WriteLine($"Benefício de R${valor} adicionado com sucesso.");
                }
                else
                {
                    Console.WriteLine("O valor do benefício deve ser maior que zero.");
                }
                ValorBeneficio = valor;
            }
        }

        public double CalcularSalarioLiquido()
        {
            Salario -= Impostos;
            return Salario;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Valor dos impostos: R${Impostos}");
            Console.WriteLine($"Valor dos benefícios: R${ValorBeneficio}");
            Console.WriteLine($"Salário líquido: R${CalcularSalarioLiquido()}");
        }
    }
}
