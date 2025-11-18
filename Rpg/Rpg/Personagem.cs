using System;

namespace Rpg
{
    public abstract class Personagem
    {
        public string Nome { get; protected set; }
        public int Vida { get; protected set; }
        public int Forca { get; protected set; }
        public int Defesa { get; protected set; }

        protected Random dado = new Random();

        public virtual int Atacar()
        {
            return Forca + dado.Next(1, 21);
        }

        public virtual void Defender(int danoRecebido)
        {
            int danoFinal = Math.Max(danoRecebido - Defesa, 0);
            Vida -= danoFinal;

            // Feito para que a vida não de valores negativos
            if (Vida < 0)
                Vida = 0;

            Console.WriteLine($"{Nome} perdeu {danoFinal} de vida. Vida restante: {Vida}");
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }
}
