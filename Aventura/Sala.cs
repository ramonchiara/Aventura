using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    class Sala
    {
        public static readonly int NORTE = 0;
        public static readonly int SUL = 1;
        public static readonly int LESTE = 2;
        public static readonly int OESTE = 3;

        private string descricao;
        private Sala[] salas;

        public Sala(string descricao)
        {
            this.descricao = descricao;
            this.salas = new Sala[4];
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetSala(int direcao, Sala sala)
        {
            if (salas[direcao] == null)
            {
                salas[direcao] = sala;
                sala.SetSala(Oposto(direcao), this);
            }
        }

        private int Oposto(int direcao)
        {
            switch (direcao)
            {
                case 0: return 1;
                case 1: return 0;
                case 2: return 3;
                case 3: return 2;
                default: throw new ArgumentException();
            }
        }

        public bool PossoIrPara(int direcao)
        {
            return salas[direcao] != null;
        }

        public Sala GetSala(int direcao)
        {
            return salas[direcao];
        }
    }
}
