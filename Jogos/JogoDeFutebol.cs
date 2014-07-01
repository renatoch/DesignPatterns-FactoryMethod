using Jogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos
{
    public class JogoDeFutebol : Jogo
    {
        private List<Cartao> cartoes;
        public override string Iniciar()
        {
            return "Jogo de Futebol iniciado!";
        }

        public void RegistrarCartao()
        {
            cartoes.Add(new Cartao() { Time = 1, Jogador = 1, Amarelo = true, Vermelho = false });
        }

        public JogoDeFutebol(EspacoDeJogo espacoDeJogo)
        {

        }

    }
}
