using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Consulta
    {
        public string Descricao { get; set; }
        public string Data { get; set; }
    }
    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Consulta> Consultas { get; set; }

        public Paciente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Consultas = new List<Consulta>();
        }

        public void AddConsulta()
        {
            do
            {
                Console.WriteLine("Insira a consulta realizada pelo paciente: ");
                string novaConsulta = Console.ReadLine();

                Console.WriteLine("Insira a data em que a consulta foi realizada: (DD/MM/YYYY)");
                string dataConsulta = Console.ReadLine();


                Consulta consulta = new Consulta{ Descricao = novaConsulta, Data = dataConsulta };
                Consultas.Add(consulta);

                Console.WriteLine("Deseja adicionar uma nova consulta?: (S/N)");
                string escolha = Console.ReadLine();

                if (!escolha.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Encerrando sisitema...");
                    break;
                }
            } while (true);
        }

        public void ExibirConsultas()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Histórico de Consultas:");

            foreach (Consulta consulta in Consultas)
            {
                    Console.WriteLine($"- {consulta.Descricao} em {consulta.Data}");
            }
        }
    }
}
