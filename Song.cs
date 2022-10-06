using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Song
    {
        public String Title { get; set; }
        public List<Artist> Artist;
        public enum SongGenre
        {
            Pop,
            Rock,
            Hip_Hop,
            Rap,
            Country,
            Folk,
            Jazz,
            Heavy_Metal,
            Disco,
            Classical,
            Techno,
            Indie_Rock,
            Psychedelic_Rock
        }
        private int Lenght { get; set; }

        public Song(string title, List<Artist> Artist, int lenght) // class Genre
        {
            Title = title;
            this.Artist = Artist;
            Lenght = lenght;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
