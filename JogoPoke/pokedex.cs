using JogoPoke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    public class pokedex
    {

        public pokedex()
        {
            this.InicializaLista();
        }

        private List<pokemonPlus> pokemons;

        public List<pokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            //Instanciar a lista
            this.pokemons = new List<pokemonPlus>();
            pokemonPlus p = new pokemonPlus("pikachu", " descriçao", 80);
            this.pokemons.Add(p);
            p = new pokemonPlus("squirtle", " desriçao", 90);
            this.pokemons.Add(p);

            //inserir 10 pokes
            p = new pokemonPlus("cindaquil", "descriçao", 90);
            this.pokemons.Add(p);
            p = new pokemonPlus("mew", "descriçao", 95);
            this.pokemons.Add(p);
            p = new pokemonPlus("mewtwo", "descriçao", 100);
            this.pokemons.Add(p);
            p = new pokemonPlus("eevee", "descriçao", 75);
            this.pokemons.Add(p);
            p = new pokemonPlus("umbreom", "descriçao", 85);
            this.pokemons.Add(p);
            p = new pokemonPlus("glaceon", "descriçao", 85);
            this.pokemons.Add(p);
            p = new pokemonPlus("rayquaza", "descriçao", 100);
            this.pokemons.Add(p);
            p = new pokemonPlus("lunala", "descriçao", 100);
            this.pokemons.Add(p);
            p = new pokemonPlus("charizard", "descriçao", 95);
            this.pokemons.Add(p);
            p = new pokemonPlus("totodile", "descriçao", 75);
            this.pokemons.Add(p);
            p = new pokemonPlus("beetree", "descriçao", 50);
            this.pokemons.Add(p);


        }

        public void ListarPokemons()
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                Console.WriteLine("codigo do pokemon: " + i);
                this.pokemons[i].ExibirDadosPoke();
                //Pokes p = this.pokemons[i]; // alternativa
                //p.ExibirDadosPoke();
            }
        }

    }
}
