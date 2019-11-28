using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesSettersGetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Movie
    {
        string title;
        string director;
        string ratings;
        int userRatings;

        // G, PC,PG-13,R,undefined
        //userRating not higher 0 and not lower than 0

        public Movie (string _title, string _director, string _ratings, int _userRatings)
        {
            title = _title;
            director = _director;
            Ratings = _ratings;
            UserRatings = _userRatings;

           
        }

        String Title 
          {
            get { return title; }
            
          }
        String Director
          {
               get { return director; }
                
          }
        String Ratings
        {
            get { return ratings; }
            set
            {
                string[] ratingsArray = new string[] { "G", "PG", "PG - 13", "R", "undefined" };

                if (ratingsArray.Contains(value))
                {

                    Ratings = value;
                }

                else
                {
                    Ratings = "undefined";
                }

            }



        }

        Int32 UserRatings
        {
            get { return userRatings; }

            set
               {
                  if (userRatings>=0 && userRatings <=10)
                  {
                    userRatings = value;
                  }
                  else
                   {
                    userRatings = 0;
                   }
                }
        }
    }
     class Movies
    {
        
        
        List <Movie>  moviesList = new List <Movie> ();

        public void addMovie (Movie movie)
        {
            moviesList.Add(movie);
        }

        public void showMovies (Movies items)
        {
            foreach (Movie item in moviesList)
            {
                Console.WriteLine(item);
            }
        }
      }
}
