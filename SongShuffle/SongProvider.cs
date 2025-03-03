using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongShuffle
{
    class SongProvider
    {
        public enum Decades
        {
            Eighties,
            Nineties,
            TwoThousands,
            TwentyTens
        }

        public List<Song> SongBank = new List<Song>();

        private List<Song> EightiesSongs = new List<Song>()
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

        private List<Song> NinetiesSongs = new List<Song>()
        {
            new Song("Smells Like Teen Spirit", "Nirvana", "Nevermind", "Grunge", 1991),
            new Song("Wonderwall", "Oasis", "(What's the Story) Morning Glory?", "Britpop", 1995),
            new Song("Enter Sandman", "Metallica", "Metallica", "Metal", 1991),
            new Song("Losing My Religion", "R.E.M.", "Out of Time", "Alternative Rock", 1991),
            new Song("Creep", "Radiohead", "Pablo Honey", "Alternative Rock", 1992),
            new Song("Black Hole Sun", "Soundgarden", "Superunknown", "Grunge", 1994),
            new Song("Basket Case", "Green Day", "Dookie", "Punk Rock", 1994),
            new Song("Torn", "Natalie Imbruglia", "Left of the Middle", "Pop Rock", 1997),
            new Song("I Want It That Way", "Backstreet Boys", "Millennium", "Pop", 1999),
            new Song("My Heart Will Go On", "Celine Dion", "Let's Talk About Love", "Pop", 1997),
            new Song("No Scrubs", "TLC", "FanMail", "R&B", 1999),
            new Song("Baby One More Time", "Britney Spears", "...Baby One More Time", "Pop", 1999),
            new Song("Vogue", "Madonna", "I'm Breathless", "Pop", 1990),
            new Song("Gangsta's Paradise", "Coolio", "Gangsta's Paradise", "Hip Hop", 1995),
            new Song("I Will Always Love You", "Whitney Houston", "The Bodyguard", "R&B", 1992)
        };

        private List<Song> TwoThousandsSongs = new List<Song>()
        {
            new Song("In the End", "Linkin Park", "Hybrid Theory", "Nu Metal", 2000),
            new Song("Hey Ya!", "OutKast", "Speakerboxxx/The Love Below", "Hip Hop", 2003),
            new Song("Crazy in Love", "Beyoncé", "Dangerously in Love", "R&B", 2003),
            new Song("Hips Don't Lie", "Shakira", "Oral Fixation, Vol. 2", "Pop", 2006),
            new Song("Umbrella", "Rihanna", "Good Girl Gone Bad", "Pop", 2007),
            new Song("Seven Nation Army", "The White Stripes", "Elephant", "Rock", 2003),
            new Song("Mr. Brightside", "The Killers", "Hot Fuss", "Rock", 2003),
            new Song("Rolling in the Deep", "Adele", "21", "Pop", 2010),
            new Song("Hot in Herre", "Nelly", "Nellyville", "Hip Hop", 2002),
            new Song("Lose Yourself", "Eminem", "8 Mile", "Hip Hop", 2002),
            new Song("Clocks", "Coldplay", "A Rush of Blood to the Head", "Alternative Rock", 2002),
            new Song("Toxic", "Britney Spears", "In the Zone", "Pop", 2003),
            new Song("Gold Digger", "Kanye West", "Late Registration", "Hip Hop", 2005),
            new Song("Poker Face", "Lady Gaga", "The Fame", "Pop", 2008),
            new Song("I Gotta Feeling", "The Black Eyed Peas", "The E.N.D.", "Pop", 2009)
        };

        private List<Song> TwoThousandTensSongs = new List<Song>()
        {
            new Song("Uptown Funk", "Mark Ronson ft. Bruno Mars", "Uptown Special", "Funk", 2014),
            new Song("Shape of You", "Ed Sheeran", "÷", "Pop", 2017),
            new Song("Blinding Lights", "The Weeknd", "After Hours", "Synthwave", 2019),
            new Song("Rolling in the Deep", "Adele", "21", "Pop", 2010),
            new Song("Despacito", "Luis Fonsi ft. Daddy Yankee", "Vida", "Reggaeton", 2017),
            new Song("Old Town Road", "Lil Nas X", "7", "Country Rap", 2019),
            new Song("Happy", "Pharrell Williams", "G I R L", "Pop", 2013),
            new Song("Bad Guy", "Billie Eilish", "When We All Fall Asleep, Where Do We Go?", "Pop", 2019),
            new Song("Can't Stop the Feeling!", "Justin Timberlake", "Trolls", "Pop", 2016),
            new Song("Closer", "The Chainsmokers ft. Halsey", "Collage", "EDM", 2016),
            new Song("Shake It Off", "Taylor Swift", "1989", "Pop", 2014),
            new Song("Humble", "Kendrick Lamar", "Damn", "Hip Hop", 2017),
            new Song("Roar", "Katy Perry", "Prism", "Pop", 2013),
            new Song("All of Me", "John Legend", "Love in the Future", "R&B", 2013),
            new Song("Someone Like You", "Adele", "21", "Pop", 2011)
        };

        public SongProvider(Decades decade)
        {
            switch (decade)
            {
                case Decades.Eighties:
                    SongBank = EightiesSongs; break;
                case Decades.Nineties:
                    SongBank = NinetiesSongs; break;
                case Decades.TwoThousands:
                    SongBank = TwoThousandsSongs; break;
                case Decades.TwentyTens:
                    SongBank = TwoThousandTensSongs; break;
                default:
                    throw new ArgumentException("Must include a valid decade.");
            }
        }

        public int Counter { get; set; } = 0;

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
