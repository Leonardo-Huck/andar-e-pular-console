using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andar_e_pular_console
{
    internal class Cenario
    {
        public string Chao { get; set; }
        public byte Tamanho { get; set; }

        public Cenario(string chao, byte tamanho) 
        {
            this.Chao = chao;
            this.Tamanho = tamanho;
        }

        public void Imprime(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            //Primeira Linha

            if(player.Pulando)
            {
                for(byte i = 0; i < player.Posicao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(player.Aparencia);
            }
            else
            {
                Console.WriteLine();
            }

            //Segunda Linha

            for(byte i = 0; i < player.Posicao; i++)
                Console.Write(Chao);

            if (player.Pulando) Console.Write(Chao);
            else Console.Write(player.Aparencia);

            for (byte i = 0; i < (Tamanho - player.Posicao); i++)
                Console.Write(Chao);
        }
    }
}
