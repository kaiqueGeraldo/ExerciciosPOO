using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class ContaBancaria
    {
        public string numeroConta;
        public string nomeTitular;
        public double saldo;

        public ContaBancaria(string numeroConta, string nomeTitular, double saldoInicial)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldo = saldoInicial;
        }

        public void Depositar(string deposito)
        {
            Console.WriteLine("Quanto deseja depositar?: ");
            double valor = double.Parse(Console.ReadLine());

            if (!deposito.Equals("S", StringComparison.CurrentCultureIgnoreCase))
            {
            }
            else
            {
                if (valor > 0)
                {
                    saldo += valor;
                    Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("O valor do depósito deve ser maior que zero.");
                }
            }
        }

        public void Sacar(string saque)
        {
            Console.WriteLine("Quanto deseja sacar?: ");
            double valor = double.Parse(Console.ReadLine());

            if (!saque.Equals("S", StringComparison.CurrentCultureIgnoreCase))
            {
            }
            else
            {
                if (valor > 0)
                {
                    if (saldo >= valor)
                    {
                        saldo -= valor;
                        Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para realizar o saque.");
                    }
                }
                else
                {
                    Console.WriteLine("O valor do saque deve ser maior que zero.");
                }
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nNúmero da conta: {numeroConta}");
            Console.WriteLine($"Nome do titular: {nomeTitular}");
            Console.WriteLine($"Saldo atual: R${saldo}");
        }
    }
}
