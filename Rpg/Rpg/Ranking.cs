using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Ranking
    {
        private List<Vitoria> vitorias = new List<Vitoria>();

        public void RegistrarVitoria(Personagem vencedor)
        {
            // Procura se o personagem ta no ranking
            Vitoria vitoriaExistente = null;
            foreach (var v in vitorias)
            {
                if (v.Nome == vencedor.Nome)
                {
                    vitoriaExistente = v;
                    break;
                }
            }

            // Caso não esteja, será adicionado
            if (vitoriaExistente == null)
            {
                vitoriaExistente = new Vitoria(vencedor.Nome);
                vitorias.Add(vitoriaExistente);
            }

            vitoriaExistente.AdicionarVitoria();
        }

        public void MostrarRanking()
        {
            Console.WriteLine("\n=====  RANKING FINAL  =====");
            foreach (var v in vitorias)
            {
                Console.WriteLine($"{v.Nome} - Vitórias: {v.Quantidade}");
            }
        }
    }

    // Armazena as vitórias
    public class Vitoria
    {
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }

        public Vitoria(string nome)
        {
            Nome = nome;
            Quantidade = 0;
        }

        public void AdicionarVitoria()
        {
            Quantidade++;
        }
    }
}