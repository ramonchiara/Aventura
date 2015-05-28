using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    class Jogo
    {
        private Sala atual;
        private Cavaleiro cavaleiro;
        private Princesa princesa;

        public Jogo()
        {
            Sala inicial = new Sala("Você está em uma sala muito empoeirada com algumas caveiras no canto...");
            Sala salao = new Sala("Você está no salão principal do castelo.");
            Sala torre = new Sala("Você achou a torre!!!");
            inicial.SetSala(Sala.LESTE, salao);
            salao.SetSala(Sala.LESTE, torre);

            atual = inicial;
            cavaleiro = new Cavaleiro();
            cavaleiro.Entrar(atual);

            princesa = new Princesa();
            princesa.Entrar(torre);
        }

        public string GetDescricaoAtual()
        {
            return cavaleiro.GetEstaVendo();
        }

        public string Executar(string comando)
        {
            string resultado = "";

            switch (comando.ToLower())
            {
                case "norte": resultado = cavaleiro.Ir(Sala.NORTE); break;
                case "sul": resultado = cavaleiro.Ir(Sala.SUL); break;
                case "leste": resultado = cavaleiro.Ir(Sala.LESTE); break;
                case "oeste": resultado = cavaleiro.Ir(Sala.OESTE); break;
            }

            return resultado;
        }

        public bool IsPrincesaSalva()
        {
            return cavaleiro.GetEstaVendo(princesa);
        }
    }
}
