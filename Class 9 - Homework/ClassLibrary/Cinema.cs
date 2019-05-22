using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassLibrary
{
    public class InitializationException : Exception
    {
        public string Message { get; set; }
    }

    public class Cinema
    {
        //Make a class Cinema. Cinema must have: Name, Halls , ListOfMovies
        //Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Name”
        //We will provide 10 movies per cinema to put in the cinema movies list

        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> ListOFMovies { get; set; }

        public Cinema(string name, int halls)
        {
            Name = name;
            Halls = halls;
        }
        public Cinema()
        {

        }

        public void MoviePlaying(Movie movie)
        {
            var list = ListOFMovies.Where(m => m.Title == movie.Title).ToList();
            try
            {
                if (list.Count == 0)
                {
                    throw new System.ArgumentException($"There is no film {movie.Title} in the cinema {Name}");
                    
                }
                else
                {
                    Console.WriteLine($"Watching {movie.Title}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
           
        }

    }
}
