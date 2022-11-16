using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GibranSpotivy;


namespace GibranSpotivy
{
    internal class SuperUser : Person
    {
        public SuperUser(string user) : base(user)
        {
            
        }



        public void AddFriend(Person person)
        {
            //Person per = new Person(person.Name);
            Friends.Add(person);
        }

        public void SelectFriend()
        {
            //Console.WriteLine("select a friend");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Friends.ElementAt(num);

        }


        public void RemoveFriend(Person person)
        {
            for (int i = 0; i < Friends.Count; i++)
            {
                if (Friends[i] == person)
                {
                    Friends.Remove(Friends[i]);
                    Console.WriteLine("user is verwijderd");
                }
            }

        }



        PlayList CreatePlayList(string name)
        {
            return null;
        }



        public void RemovePlayList(int num)
        {
            for (int i = 0; i < PlayList.Count; i++)
            {
                if (PlayList[i].Equals(num))
                {
                    PlayList.Remove(PlayList[i]);
                    Console.WriteLine("Playlist has been moved to the trash");
                }
            }


        }



        public void AddToPlayList(iPlayable iPlayable)
        {


            
        }



        public void RemoveFromPlaylist(iPlayable iPlayable)
        {



        }
    }
}
