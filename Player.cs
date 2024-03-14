using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andar_e_pular_console
{
    internal class Player
    {
        public byte Posicao { get; set; }
        public string Aparencia { get; set; }
        public string FacingRight { get; set; }
        public string FacingLeft { get; set; }
        public Boolean Pulando { get; set; }  

        public Player(string right, string left)
        {
            Posicao = 0;
            FacingRight = right;
            FacingLeft = left;
            Aparencia = FacingRight;
            Pulando = false;
        }

        public void Pula()
        {
            Console.Beep(234, 100);
        }

        public void anda(Boolean direcao, byte limite)
        {
            if (direcao)
            {
                if (Posicao < limite)
                {
                    Posicao++;
                    Aparencia = FacingRight;
                }
            } 
            else
            {
                if (Posicao > 0)
                {
                    Posicao--;
                    Aparencia = FacingLeft;
                }
            }
        }


    }
}
