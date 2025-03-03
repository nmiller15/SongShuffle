using Microsoft.Extensions.Configuration;

namespace SongShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = LoadConfig();
            Welcome();
            DisplaySong(config);
        }

        public static IConfiguration LoadConfig()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to the jam session!");
            Console.WriteLine("Press enter to get started...");
            Console.ReadLine();
        }

        public static void DisplaySong(IConfiguration config)
        {
            var userResponse = string.Empty;

            var decade = config["Decade"] switch
            {
                "Nineties" => SongProvider.Decades.Nineties,
                "TwoThousands" => SongProvider.Decades.TwoThousands,
                "TwentyTens" => SongProvider.Decades.TwentyTens,
                _ => SongProvider.Decades.Eighties
            };

            var provider = new SongProvider(decade);
            Song song = new Song();

            while (userResponse != "q")
            {
                song = provider.ShuffleSelect();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Now playing {song.ToString()}");
                Console.WriteLine();
                Console.WriteLine(@"
            ╔══╗
            ║██║
            ║(O)║♫ ♪ ♫ ♪
            ╚══╝
    ▄ █ ▄ █ ▄ ▄ █ ▄ █ ▄ █
      
    ");
                Console.WriteLine();
                Console.WriteLine("Ready for another jam? Hit enter!");
                Console.WriteLine("(Type q to quit.)");

                userResponse = Console.ReadLine()?.ToLower();
            }
        }
    }
}