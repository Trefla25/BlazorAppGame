namespace BlazorAppGame
{
    public class GamesServices
    {
        public List<GamesItem> games = new List<GamesItem>();

        public void AddGame(GamesItem game)
        {
            games.Add(game);
        }
    }
}
