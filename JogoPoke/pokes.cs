using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{


    public class Pokes
    {

        public Pokes()
        {
            this.Nome = "";
            this.DadosPoke = "";
        }

        public Pokes(String Nome, String DadosPoke)
        {
            this.Nome = Nome;
            this.DadosPoke = DadosPoke;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set
            {
                String texto = value;
                nome = texto;
            }
        }

        private String dadosPoke; //armazena o valor da propriedade da descriçao

        public String DadosPoke //representa a descriçao do poke
        {
            get { return this.dadosPoke; }
            set
            {
                this.dadosPoke = value;
            }
        }

        public void ExibirDadosPoke()
        {
            Console.WriteLine("nome do poke: " + this.Nome);
            Console.WriteLine("descrição do poke: " + this.DadosPoke);
        }

        public void ExibirDadosPoke(Boolean formatado)
        {
            if (formatado == true)
            {
                Console.WriteLine("poke " + this.Nome + ": " + this.DadosPoke.ToLower());
            }
            else
            {
                Console.WriteLine("nome do poke: " + this.Nome);
                Console.WriteLine("descrição do poke: " + this.DadosPoke);
            }

        }


    }
}
