using pooPokedex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPoke
{
    public class pokemonPlus:Pokes
    {
        public pokemonPlus():base() 
        {
            this.poder = 0;
        }

        public pokemonPlus(string nome, string descricao, int poder) : base(nome, descricao)
        {
            this.poder = poder;
        }
        public int poder { get; set; }

        public void ExibirDadosPokePlus()
        {
            Console.WriteLine("nome do poke: " + this.Nome);
            Console.WriteLine("descrição do poke: " + this.DadosPoke);
            Console.WriteLine("poder: " + this.poder);
        }
    }
}
