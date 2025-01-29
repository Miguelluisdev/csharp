using System;

public class BankAccount
{
    private double saldo;
    public double Saldo
    {
        get { return saldo; }
        private set { saldo = value; }
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado com sucesso!");
        }
    }

}