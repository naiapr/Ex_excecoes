using System;
using System.Globalization;
using Ex_Excecoes.Entities;
using Ex_Excecoes.Entities.Excecoes;

namespace Ex_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" Entre com os dados da Conta: ");
                Console.WriteLine();
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string nome = Console.ReadLine();
                Console.Write("Saldo Inicial: ");
                double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Limite de Saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta conta = new Conta(numero, nome, saldo, limiteSaque);

                Console.WriteLine();
                Console.Write("Valor para Saque: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(valor);
            }
            catch(DominioExcecao e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }

        }
    }
}
