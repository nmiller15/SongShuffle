using Microsoft.Extensions.Configuration;

namespace SongShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            DisplaySong();
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to the jam session!");
            Console.WriteLine("Press enter to get started...");
            Console.ReadLine();
        }

        public static void DisplaySong()
        {
            var userResponse = string.Empty;

            var provider = new SongProvider();
            Song song = new Song();

            while (userResponse != "q")
            {
                song = provider.ShuffleSelect();

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Now playing {song.ToString()}");
                Console.WriteLine();
                Console.WriteLine(@"
            ╔═══╗
            ║███║
            ║(O)║♫ ♪ ♫ ♪
            ╚═══╝
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
