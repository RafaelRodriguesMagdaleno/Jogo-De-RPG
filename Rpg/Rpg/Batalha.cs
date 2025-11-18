using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Batalha
    {
        public Personagem Iniciar(Personagem p1, Personagem p2)
        {
            Console.WriteLine($"\nIniciando batalha entre {p1.Nome} e {p2.Nome}");
            Console.WriteLine("-----------------------------------");

            while (p1.EstaVivo() && p2.EstaVivo())
            {
                int danoP1 = p1.Atacar();
                p2.Defender(danoP1);
                if (!p2.EstaVivo()) break;

                int danoP2 = p2.Atacar();
                p1.Defender(danoP2);

                Console.WriteLine("---- Próximo turno ----");
            }

            Personagem vencedor = p1.EstaVivo() ? p1 : p2;
            Console.WriteLine($"\n {vencedor.Nome} venceu a batalha!\n");
            return vencedor;
        }
    }
}
