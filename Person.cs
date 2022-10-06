using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenSpoty
{
    internal class Person
    {
        public string Name { get; set; }
        private List<Person> Friends = new List<Person>();
        private List<PlayList> PlayList = new List<PlayList>();



        public Person(string name)
        {
            this.Name = name;
        }

        public void ShowFriends(List<Person> person)
        {

        }
        
        public void ShowPlayLists(List<PlayList> playlist)
        {

        }

        public void selectPlayList(int songNum)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
