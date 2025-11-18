using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Necromante : Personagem
    {
        public Necromante(string nome)
        {
            Nome = nome;
            Vida = 100;
            Forca = 44;
            Defesa = 12;
        }

        public override int Atacar()
        {
            int rolagem = dado.Next(1, 21);
            int dano = Forca + rolagem;
            Console.WriteLine($"{Nome} usou mortos infernais com o poder {dano}");
            return dano;
        }
    }
}