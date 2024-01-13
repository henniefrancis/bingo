namespace Bingo.Config.Images
{
    public static class System
    {
        private static string content = "wwwroot/content/system.json";

        public static string FavIcon { get; set; } = new ConfigurationBuilder().AddJsonFile(content).Build().GetSection("Images:System")["FavIcon"];
    }
}
