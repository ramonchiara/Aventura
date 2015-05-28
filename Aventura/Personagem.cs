using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    class Personagem
    {
        private Sala sala;

        public void Entrar(Sala sala)
        {
            this.sala = sala;
        }

        public string Ir(int direcao)
        {
            bool possoIr = sala.PossoIrPara(direcao);

            if (possoIr)
            {
                sala = sala.GetSala(direcao);
            }

            return possoIr ? "Você mudou de sala" : "Você não pode ir nessa direção";
        }

        public string GetEstaVendo()
        {
            return sala.GetDescricao();
        }

        public bool GetEstaVendo(Personagem personagem)
        {
            return personagem.GetSala() == sala;
        }

        public Sala GetSala()
        {
            return sala;
        }
    }
}
