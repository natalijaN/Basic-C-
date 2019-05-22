using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Exercise_2___Favourite_Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            Song song1 = new Song("Du bist die Ruh", 3.556, Song.Genre.Classical);
            Song song2 = new Song("Piano Quartet", 4.5, Song.Genre.Classical);
            Song song3 = new Song("Carmen", 5.2, Song.Genre.Classical);
            Song song4 = new Song("Don’t Come Out the House", 4.8, Song.Genre.Hip_Hop);
            Song song5 = new Song("King's Dead",2.3, Song.Genre.Hip_Hop);
            Song song6 = new Song("New Patek", 5, Song.Genre.Hip_Hop);
            Song song7 = new Song("STAIRWAY TO HEAVEN", 4, Song.Genre.Rock);
            Song song8 = new Song("BOHEMIAN RHAPSODY", 5.1, Song.Genre.Rock);
            Song song9 = new Song("WHOLE LOTTA LOVE", 4.5, Song.Genre.Rock);
            Song song10 = new Song("Teach Me", 3.8, Song.Genre.Techno);
            Song song11 = new Song("Your Mind ", 3.2, Song.Genre.Techno);
            Song song12 = new Song("Cashmere", 4.0, Song.Genre.Techno);

            
            Person personOne = new Person(7, "Stefan", "Trajkov", 24, Song.Genre.Rock);

            personOne.listOfFavouriteSongs(song1);
            personOne.listOfFavouriteSongs(song9);
            personOne.listOfFavouriteSongs(song8);
            personOne.listOfFavouriteSongs(song12);

            personOne.GetFavSongs();


            Person personTwo = new Person(2, "Natalija", "Nikolova", 24, Song.Genre.Techno);

            personTwo.FavouriteSongs.Add(song1);
            personTwo.FavouriteSongs.Add(song7);
            personTwo.FavouriteSongs.Add(song3);
            personTwo.FavouriteSongs.Add(song5);

            personTwo.GetFavSongs();


            Person personThree = new Person(5, "Pavle", "Nikolov", 26, Song.Genre.Hip_Hop);

            personThree.GetFavSongs();

            Console.ReadLine();
        }
    }
}
