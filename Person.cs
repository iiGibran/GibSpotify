using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibranSpotivy
{
    internal class Person
    {
        public string Name { get; set; }
        protected List<Person> Friends = new List<Person>();
        protected List<PlayList> PlayList = new List<PlayList>();



        public Person(string name)
        {
            this.Name = name;
        }


        
        public List<Person> ShowFriends()
        {
            if (Friends.Count != 0)
            {
                foreach (Person friend in Friends)
                {
                    Console.WriteLine(friend.Name);
                    //return Friends;
                }
            }
            else
            {
                Console.WriteLine(Friends + "This user doesnt have friends");
            }
           
            return Friends;

        }

        public void ShowPlayLists(List<PlayList> playlist)
        {
            if (playlist.Count != 0)
            {
                foreach (PlayList perPlay in playlist)
                {
                    Console.WriteLine(perPlay);
                    //return Friends;
                }
            }
            else
            {
                Console.WriteLine(Friends + "This user doesnt have friends");
            }

            //return playlist;
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
