using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongShuffle
{
    class SongProvider
    {
        public List<Song> SongBank = new List<Song>()
        {
            new Song("Billie Jean", "Michael Jackson", "Thriller", "Pop", 1982),
            new Song("Like a Virgin", "Madonna", "Like a Virgin", "Pop", 1984),
            new Song("Sweet Child o' Mine", "Guns N' Roses", "Appetite for Destruction", "Rock", 1987),
            new Song("Livin' on a Prayer", "Bon Jovi", "Slippery When Wet", "Rock", 1986),
            new Song("Every Breath You Take", "The Police", "Synchronicity", "Rock", 1983),
            new Song("Take On Me", "A-ha", "Hunting High and Low", "Synthpop", 1985),
            new Song("With or Without You", "U2", "The Joshua Tree", "Rock", 1987),
            new Song("I Wanna Dance with Somebody", "Whitney Houston", "Whitney", "Pop", 1987),
            new Song("Eye of the Tiger", "Survivor", "Eye of the Tiger", "Rock", 1982),
            new Song("Beat It", "Michael Jackson", "Thriller", "Pop", 1982),
            new Song("Jump", "Van Halen", "1984", "Rock", 1984),
            new Song("Girls Just Want to Have Fun", "Cyndi Lauper", "She's So Unusual", "Pop", 1983),
            new Song("Under Pressure", "Queen & David Bowie", "Hot Space", "Rock", 1981),
            new Song("Purple Rain", "Prince", "Purple Rain", "Rock", 1984),
            new Song("Don't Stop Believin'", "Journey", "Escape", "Rock", 1981),
            new Song("Thriller", "Michael Jackson", "Thriller", "Pop", 1982),
            new Song("Another One Bites the Dust", "Queen", "The Game", "Rock", 1980),
            new Song("Call Me", "Blondie", "American Gigolo", "Rock", 1980),
            new Song("Africa", "Toto", "Toto IV", "Rock", 1982),
            new Song("Faith", "George Michael", "Faith", "Pop", 1987),
            new Song("Careless Whisper", "George Michael", "Make It Big", "Pop", 1984),
            new Song("Wake Me Up Before You Go-Go", "Wham!", "Make It Big", "Pop", 1984),
            new Song("In the Air Tonight", "Phil Collins", "Face Value", "Rock", 1981),
            new Song("Time After Time", "Cyndi Lauper", "She's So Unusual", "Pop", 1983),
            new Song("Material Girl", "Madonna", "Like a Virgin", "Pop", 1984),
        };
        public int Counter { get; set; } = 0;

        public SongProvider()
        {
            
        }


        public Song ShuffleSelect()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, SongBank.Count);
            while (SongBank[randomIndex].HasPlayed)
            {
                randomIndex = random.Next(0, SongBank.Count);
                if (Counter >= SongBank.Count) { SongBank.Select(s => s.HasPlayed == false); }

                Counter++;
            }
            return SongBank[randomIndex];
        }
    }
}
