using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Exercise_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Make a class Movie. Movie must have: Title, Genre, Rating, TicketPrice and a constructor for setting them
            //Rating should be a number from 1 to 5. Throw exception if its more or less(you should also handle other exceptions)
            //Set the TicketPrice to be 5 * Rating when creating a new object
            //Genre should be an enum with Comedy, Horror, Action, Drama and SciFi
            //Make a class Cinema. Cinema must have: Name, Halls , ListOfMovies
            //Cinema should have method MoviePlaying  that will have a parameter ‘movie’ and then print out in the console “Watching Movie.Name”
            //We will provide 10 movies per cinema to put in the cinema movies list


            //Make a user interface that will choose a cinema.
            //After that the user should chose if he likes to see all movies or by genre.
            //All movies - show all movies and give option to choose a movie (the movie Playing method should be called).
            //By genre the user should input his favorite genre and a list of movies from that genre from the cinema should be displayed and give an option to choose one.
            //If the user enter a wrong input throw an exception.
            //Handle all exceptions with Try/Catch.



            //Create list of movies - handling out of range exceptions

            Console.WriteLine(@"Input rating between 1 and 5 for movie ""Avengers: Infinity War"" ");
            int ratigMovie1 = Convert.ToInt32(Console.ReadLine());

            Movie movie1 = new Movie("Avengers: Infinity War", Genre.Action, ratigMovie1);

            Console.WriteLine(@"Input rating between 1 and 5 for movie ""Maze Runner: The Death Cure"" ");
            int ratigMovie2 = Convert.ToInt32(Console.ReadLine());

            Movie movie2 = new Movie("Maze Runner: The Death Cure", Genre.SciFi, ratigMovie2);

            Console.WriteLine(@"Input rating between 1 and 5 for movie ""Ocean's Eight"" ");
            int ratigMovie3 = Convert.ToInt32(Console.ReadLine());

            Movie movie3 = new Movie("Ocean's Eight", Genre.Comedy, ratigMovie3);

            Console.WriteLine(@"Input rating between 1 and 5 for movie ""Red Sparrow"" ");
            int ratigMovie4 = Convert.ToInt32(Console.ReadLine());

            Movie movie4 = new Movie("Red Sparrow", Genre.Drama, ratigMovie4);

            Console.WriteLine(@"Input rating between 1 and 5 for movie ""Annihilation"" ");
            int ratigMovie5 = Convert.ToInt32(Console.ReadLine());

            Movie movie5 = new Movie("Annihilation", Genre.Horror, ratigMovie5);

            Movie movie6 = new Movie("Wrong turn", Genre.Horror, ratigMovie5);

            List<Movie> movies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6 };


            foreach (var movie in movies)
            {
                Console.WriteLine($"The movie {movie.Title} is {movie.Genre}, has rating {movie.Rating} and the ticket prise is: {movie.TicketPrice}$");
                Console.WriteLine();
            }

            //Create Cinema, and call the method MoviePlaying()

            Cinema Cineplex = new Cinema("Cineplex", 7);

            Cineplex.ListOFMovies = new List<Movie>();

            Cineplex.ListOFMovies.Add(movie2);
            Cineplex.ListOFMovies.Add(movie4);
            Cineplex.ListOFMovies.Add(movie5);

            Cinema Greenwich = new Cinema("Greenwich Picturehouse", 10);

            Greenwich.ListOFMovies = new List<Movie>();

            Greenwich.ListOFMovies.Add(movie1);
            Greenwich.ListOFMovies.Add(movie3);
            Greenwich.ListOFMovies.Add(movie5);
            Greenwich.ListOFMovies.Add(movie6);

            Console.WriteLine("Choose a cinema!");
            Console.WriteLine();

            Console.WriteLine("Press: 1) for Cinepex 2) for Greenwich Picturehouse");

            try
            {
                int inputCinema = Convert.ToInt32(Console.ReadLine());
                Cinema userCinema = new Cinema();

                if (inputCinema == 1)
                {
                    userCinema = Cineplex;
                }
                else if (inputCinema == 2)
                {
                    userCinema = Greenwich;
                }
                else
                {
                    throw new Exception("You made wrong choice");
                }

                Console.WriteLine("Do you want to see all movies or movies by specific genre?");
                Console.WriteLine("Press 1 if you want to see all movies!");
                Console.WriteLine("Press 2 if you want to see movies by specific genre!");

                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    // code for all movies from that cinema
                    for (int i = 0; i < userCinema.ListOFMovies.Count; i++)
                    {
                        Console.WriteLine($"If you want to watch {userCinema.ListOFMovies[i].Title} press {i} ");
                    }

                    int movieChoice = Convert.ToInt32(Console.ReadLine());

                    switch(movieChoice)
                    {
                        case 1:
                            userCinema.MoviePlaying(userCinema.ListOFMovies[movieChoice]);
                            break;
                        default:
                            userCinema.MoviePlaying(userCinema.ListOFMovies[movieChoice]);
                            break;
                    }

                    
                }
                else if (userChoice == 2)
                {
                    //code from movies by specific genre
                    Console.WriteLine("Choose genre:");
                    int index = 0;
                    var listOfGenreMovies = userCinema.ListOFMovies.Select(m => m.Genre).ToList();

                    var listOfGenreMoviesWithNoDuplicates = listOfGenreMovies.Distinct().ToList();
                    foreach (var movieGenre in listOfGenreMoviesWithNoDuplicates)
                    {
                        Console.WriteLine($"{index}) {movieGenre}");
                        index++;
                    }

                    int userMovieGenre = Convert.ToInt32(Console.ReadLine());

                    Genre userGenre = new Genre();
                    switch (userMovieGenre)
                    {
                        case 1:
                            userGenre = Genre.Comedy;
                            break;
                        case 2:
                            userGenre = Genre.Horror;
                            break;
                        case 3:
                            userGenre = Genre.Action;
                            break;
                        case 4:
                            userGenre = Genre.Drama;
                            break;
                        case 5:
                            userGenre = Genre.SciFi;
                            break;
                        default:
                            throw new Exception("Incorrect input for genre!");
                    }

                    try
                    {
                        var listOfChoosenMovies = userCinema.ListOFMovies.Where(m => m.Genre == userGenre).Select(m => m.Title).ToList();
                        if(listOfChoosenMovies.Count == 0)
                        {
                            throw new Exception("No such movie genre in this cinema!");
                        }
                        else
                        {
                            int index1 = 0;
                            Console.WriteLine("Choose movie:");
                            
                            foreach (var movie in listOfChoosenMovies)
                            {
                                Console.WriteLine($"{index1}) {movie}");
                                index1++;
                            }

                            Console.WriteLine();
                            Console.WriteLine("Write the name of the movie!");

                            try
                            {
                                string finalMovie = (Console.ReadLine());
                                Console.WriteLine("You are watching " + finalMovie);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);                           
                            }                                               
                            
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    throw new Exception("Wrong input!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
