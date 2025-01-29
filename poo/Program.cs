using System;

namespace NameSpace
{
    public class Persona
    {
        private string nome;
        private int idade;

        public Persona(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string GetNome() => nome;
        public void SetNome(string nome) => this.nome = nome;

        public int GetIdade() => idade;
        public void SetIdade(int idade) => this.idade = idade;

        public void showInfo()
        {
            Console.WriteLine($"Nome: {nome} , idade: {idade}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // encapsulamento
            Persona p = new Persona("Joao", 20);
            p.showInfo();

            // herança
            Animal meuCachorro = new Cachorro("Rex");
            meuCachorro.EmitirSom();

            // polimorfismo
            IForma forma = new Circulo(5);
            Console.WriteLine(forma.CalcularArea());
            forma = new Retangulo(5, 10);
            Console.WriteLine(forma.CalcularArea());

            BankAccount conta = new BankAccount();
            conta.Depositar(1000);
            conta.Sacar(500);

        }
    }


}



