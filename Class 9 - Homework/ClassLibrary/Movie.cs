using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Movie
    {
        //Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them
        //Rating should be a number from 1 to 5. Throw exception if its more or less(you should also handle other exceptions)
        //Set the TicketPrice to be 5 * Rating when creating a new object


        public string  Title { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, double rating)
        {
            Title = title;
            Genre = genre;
            try
            {
                if (rating < 1 || rating > 5)
                {
                    throw new ArgumentOutOfRangeException("Rating is out of range");
                }
                else
                {
                    Rating = rating;
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            TicketPrice = 5;
        }



        public Movie()
        {

        }

    }
}
