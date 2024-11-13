using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsElistas 
{
    internal class Program 
    {
        struct Dadosdecadastro 
        {
            
         public string Nome;
         public string SobreNome;
        public UInt32 Idade;
        }
    static void Main(string[] args)
    {
        Dadosdecadastro  meuCadatro;
        meuCadatro.Nome = "darius";
        meuCadatro.SobreNome = "lannister";
        meuCadatro.Idade = 19;

        List<string> ListaDeNomes = new List<string>();
         ListaDeNomes.Add("joão");
         ListaDeNomes.Add("joão");
         ListaDeNomes.Add("joão"); 
         foreach (string str in ListaDeNomes) 
         {
            Console.WriteLine(str);
         }
    }
        
    }
}