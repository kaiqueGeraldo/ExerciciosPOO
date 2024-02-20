using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double[] Notas { get; set; }

        public Aluno(string nome, int matricula, double[] notas) 
        {
            Nome = nome;
            Matricula = matricula;
            Notas = notas;
        }

        public void DefinirNotas(double[] notas)
        {
            Notas = notas;
        }

        public double CalcularMedia()
        {
            if(Notas.Length == 0)
            {
                return 0;
            }
            return Notas.Sum() / Notas.Length;
        }

        public string CalcularSituacao()
        {
            double media = CalcularMedia();
            if(media >= 6)
            {
                return "Aluno Aprovado";
            }
            else
            {
                return "Aluno reprovado";
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nAluno: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Notas: {string.Join(", ", Notas)}");
            Console.WriteLine($"Média: {CalcularMedia()}");
            Console.WriteLine($"Situação: {CalcularSituacao()}");
        }
    }
}
