using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aventura
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();

            do
            {
                Console.WriteLine(jogo.GetDescricaoAtual());
                Console.Write("O que você faz? ");
                string comando = Console.ReadLine();
                string resultado = jogo.Executar(comando);
                Console.Clear();
                Console.WriteLine(resultado);
            } while (!jogo.IsPrincesaSalva());
            Console.WriteLine("Você salvou a princesa!!!");
        }
    }
}
