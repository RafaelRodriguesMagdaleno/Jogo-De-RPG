using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Cavaleiro : Personagem
    {
        public Cavaleiro(string nome)
        {
            Nome = nome;
            Vida = 100;
            Forca = 50;
            Defesa = 4;
        }

        public override int Atacar()
        {
            int rolagem = dado.Next(1, 21);
            int dano = Forca + rolagem;
            Console.WriteLine($"{Nome} usou o ataque lança de trovão com poder {dano}");
            return dano;
        }
    }
}
