using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Mago : Personagem
    {
        public Mago(string nome)
        {
            Nome = nome;
            Vida = 80;
            Forca = 20;
            Defesa = 4;
        }

        public override int Atacar()
        {
            int rolagem = dado.Next(1, 21);
            int dano = Forca + rolagem;
            Console.WriteLine($"{Nome} lançou um feitiço congelante com poder {dano}");
            return dano;
        }
    }
}
