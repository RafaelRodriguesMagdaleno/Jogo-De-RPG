using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Arena
    {
        private Ranking ranking;

        public Arena(Ranking ranking)
        {
            this.ranking = ranking;
        }

        public void RealizarBatalha(Personagem p1, Personagem p2)
        {
            var batalha = new Batalha();
            Personagem vencedor = batalha.Iniciar(p1, p2);

            ranking.RegistrarVitoria(vencedor);
        }
    }
}