using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos
{
    public abstract class Jogo
    {
        protected int jogadoresPorTime;

        public static Jogo Create(string tipoJogo)
        {
            if (tipoJogo == "Futebol")
            {   
                EspacoDeJogo campo = new CampoDeFutebol();
                return new JogoDeFutebol(campo);
            }
            else if (tipoJogo == "Tênis")
            {
                return new JogoDeTenis();
            }
            else if (tipoJogo == "Basquete")
            {
                return new JogoDeBasquete();
            }
            else
            {
                throw new NotImplementedException("Não conheço esse tipo de jogo");
            }
        }


        public abstract string Iniciar();
    }
}
