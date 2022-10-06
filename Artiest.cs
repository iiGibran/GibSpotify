using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Artist
    {
        private List<Artist> Artists;

        public void Album(List<Artist> artiest, string songName, List<Song> song)
        {

        }

        public List<Artist> ShowArtiets()
        {
            return Artists;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
