using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre genre { get; set; }

        public Song()
        {

        }

        public Song(string title, double length, Genre inputGenre)
        {
            Title = title;
            Length = length;
            genre = inputGenre;
        }

        public enum Genre
        {
            Rock = 1,
            Hip_Hop,
            Techno,
            Classical
        }
    }
}
