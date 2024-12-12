using System;

namespace ContaBancaria
{
    class ContaBanco(int numero, string titular) // classe ContaBancaria
    {
        // atributos da classe
        public int Numero { get; private set; } = numero;
        public string Titular { get; set; } = titular;
        public double Saldo { get; private set; }

        // construtor reaproveitando o anterior e adicionando saldo
        public ContaBanco(int numero, string titular, double saldo) : this(numero, titular) 
        {
            Deposito(saldo);
        }

        // metodo de deposito
        public void Deposito(double quantia) 
        {
            Saldo += quantia;
        }

        // metodo de saque
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        // override pra exibir os dados
        public override string ToString()
        {
            return $"Conta {Numero}, Titular : {Titular}, Saldo: $ {Saldo.ToString("F2")}"; 
        }
    }
}
