using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Assassino : Personagem
    {
        public Assassino(string nome)
        {
            Nome = nome;
            Vida = 60;
            Forca = 100;
            Defesa = 10;
        }

        public override int Atacar()
        {
            int rolagem = dado.Next(1, 21);
            int dano = Forca + rolagem;
            Console.WriteLine($"{Nome} usou adagas envenenadas com o poder {dano}");
            return dano;
        }
    }
}
