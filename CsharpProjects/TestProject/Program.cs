using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs 
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
    }
        
    }
}