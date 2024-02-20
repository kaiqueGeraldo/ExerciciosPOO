using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Livro
    {
        public string Nome { get; set; }
        public int QntdPags { get; set; }
        public string Status { get; set; }

        public Livro(string nome, int qntdPags)
        {
            Nome = nome;
            QntdPags = qntdPags;
        }

        public void OpcoesLivro()
        {
            do
            {
                Console.WriteLine("O que você deseja fazer? Emprestar(1); Devolver(2); Verificar disponibilidade(3)");
                int resposta = Escolha();

                if (resposta == 1)
                {
                    Emprestar();
                }
                else if (resposta == 2)
                {
                    Devolver();
                }
                else
                {
                    VerificarDisponibilidade();
                }

                Console.WriteLine("Voltar as opções do livro?: (S/N)");
                string parar = Console.ReadLine();

                if (!parar.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Parando sistema...");
                    break;
                }
            } while (true);

            int Escolha()
            {
                int resposta;
                while (!int.TryParse(Console.ReadLine(), out resposta) || resposta < 1 || resposta > 3)
                {
                    Console.WriteLine("Essa opção não está disponível! Tente uma opção válida. Emprestar(1); Devolver(2): ");
                }
                return resposta;
            }
            ExibirInformacoes();
        }

        public void Emprestar()
        {
            Status = "emprestado";
            Console.WriteLine($"Você emprestou o livro! {Status}");
        }

        public void Devolver()
        {
            Status = "Disponível para empréstimo";
            Console.WriteLine($"Você devolveu o livro! {Status}");
        }

        public void VerificarDisponibilidade()
        {
            if (Status == "emprestado")
            {
                Console.WriteLine("Livro indisponível no momento. Tente em outro dia.");
            }
            else
            {
                Console.WriteLine("Livro disponível. Deseja emprestalo?: (S/N)");
                string emprestar = Console.ReadLine();

                if (emprestar.Equals("S", StringComparison.CurrentCultureIgnoreCase))
                {
                    Emprestar();
                }
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Páginas: {QntdPags}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
