using JogoPoke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pokedex pokedex = new pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("escolha seu pokemon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //pegar o pokemon do player
                    pokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    // definir o pokemon do pc
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    pokemonPlus pPC = pokedex.Pokemons[codigo];

                    //batalhar
                    Console.Clear();
                    Console.WriteLine("DADOS DOS POKEMONS QUE IRAO LUTAR: ");
                    Console.WriteLine("DADOS DO SEU POKEMON:");
                    pPlayer.ExibirDadosPokePlus();
                    Console.WriteLine("DADOS DO POKEMON ADVERSARIO: ");
                    pPC.ExibirDadosPokePlus();

                    if (pPlayer.poder >= pPC.poder) 
                    {
                        Console.WriteLine("PARABENS! VOCE GANHOU!");
                    }
                    else 
                    {
                        Console.WriteLine("VOCE PERDEU! TENTE NOVAMENTE");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }


        }

        static int Menu()
        {
            Console.WriteLine("BATALHA POKEMON");
            Console.WriteLine("0 - sair do jogo: ");
            Console.WriteLine("1 - Listar todos pokemons que temos: ");
            Console.WriteLine("2 - batalhar: ");
            Console.Write("o que deseja fazer?");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
