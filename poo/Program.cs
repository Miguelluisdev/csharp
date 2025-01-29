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
            Persona p = new Persona("Joao", 20);
            p.showInfo();
            Animal meuCachorro = new Cachorro("Rex");
            meuCachorro.EmitirSom();

        }
    }


}



