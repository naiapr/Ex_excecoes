using Ex_Excecoes.Entities.Excecoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Excecoes.Entities
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {

        }

        public Conta(int numero, string nome, double saldo, double limiteSaque)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            double dp;
            dp = Saldo + valor;

        }


        public void Saque (double valor)
        {
            
            if (valor > Saldo)
            {
                throw new DominioExcecao("Saldo insuficiente. ");
            }else if (valor > LimiteSaque)
            {
                throw new DominioExcecao("Limite ultrapassado. ");
            }
            else
            {
                double sq;
                sq = Saldo - valor;
                Console.WriteLine("Novo Saldo: " + sq);
            }
            
        }

        
        
    }
}
