using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Monge : Personagem
    {
        public Monge(string nome)
        {
            Nome = nome;
            Vida = 120;
            Forca = 45;
            Defesa = 16;
        }

        public override int Atacar()
        {
            int rolagem = dado.Next(1, 21);
            int dano = Forca + rolagem;
            Console.WriteLine($"{Nome} usou mão divina com o poder {dano}");
            return dano;
        }
    }
}
