namespace Rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem cavaleiro = new Cavaleiro("Merlin");
            Personagem monge = new Monge("Bartolomeu");
            Personagem mago = new Mago("Gandalf");
            Personagem assassino = new Assassino("Ezio");
            Personagem necromante = new Necromante("Mordred");

            //Arena e Ranking
            var ranking = new Ranking();
            var arena = new Arena(ranking);

            // Faz as batalhas
            arena.RealizarBatalha(cavaleiro, monge);
            arena.RealizarBatalha(mago, assassino);
            arena.RealizarBatalha(necromante, cavaleiro);

            // Mostra o resultado das vitórias
            ranking.MostrarRanking();
        }
    }
}
