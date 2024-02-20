using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int QntdEstoque { get; set; }
        public decimal TotalValorEstoque { get; set; }

        public Produto(string nome, double valor, int qntdEstoque)
        {
            Nome = nome;
            Valor = valor;
            QntdEstoque = qntdEstoque;
        }

        public object CalcularEstoque()
        {
            TotalValorEstoque = (decimal)(QntdEstoque * Valor);
            return TotalValorEstoque;
        }

        public object ProdutoDisponivel()
        {
            if (QntdEstoque == 0)
            {
                Console.WriteLine($"{Nome} fora de estoque.");
            }
            else
            {
                Console.WriteLine($"{Nome} em estoque. Quantidade: {QntdEstoque}");
            }
            return QntdEstoque;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nValor total de {Nome} no estoque: R${CalcularEstoque()}");
            Console.WriteLine($"{ProdutoDisponivel()}");
        }
    }
}
