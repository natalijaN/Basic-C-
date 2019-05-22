using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Song.Genre FavoriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }


        public Person(int id, string firstName, string lastName, int age, Song.Genre inputGenre)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = inputGenre;
            FavouriteSongs = new List<Song>();
        }

        public Person()
        {

        }

        public void listOfFavouriteSongs(Song song)
        {
            if(song.genre == FavoriteMusicType)
            FavouriteSongs.Add(song);
        }


        public void GetFavSongs()
        {
           if(FavouriteSongs.Count == 0)
            {
                Console.WriteLine($"\n{FirstName} hates music!");
            }
            else
            {
                Console.WriteLine($"{FirstName}`s favourite songs are:\n");
                foreach (var song in FavouriteSongs)
                {
                    Console.WriteLine($"Song`s title: {song.Title}");
                }
            }
            Console.WriteLine("\n");
        }

    }
}
