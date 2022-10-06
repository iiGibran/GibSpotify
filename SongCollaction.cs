using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class SongCollaction 
    {
        public string Title { get; set; }
        private List<iPlayable> playables;


        // consturct method
        public SongCollaction(string name)
        {

        }

        public SongCollaction()
        {

        }

        public void ShowPlayables()
        {

        }

        // ShowPlayables : List<iPlayable>

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
