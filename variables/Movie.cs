using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    public class Movie
    {  
        //static variable
        public static string Name;

        //Instance variable
        public int ticketId;
        public string seatNumber;

        public Movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            Movie movie = new Movie();
            Movie.Name = name;
            movie.ticketId = ticketId;
            movie.seatNumber = seatNumber;

            return movie;
        }
    }

}
