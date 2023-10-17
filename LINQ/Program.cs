namespace LINQ
{
    public class Program
    {
        static void Main()
        {
            List<string> videoGames = new List<string>
            {
               "The Legend of Zelda Ocarina of Time",
               "The Legend of Zelda Majora's Mask",
               "The Elder Scrolls V: Skyrim",
               "Super Castlevania IV",
               "Demon's Souls",
               "Elden Ring",
               "Dark Souls",
            };

            var orderGames = videoGames.OrderBy(game => game.Length);

            foreach (var game in orderGames) 
            {
                Console.WriteLine(game);
            }
        }
    }
}
