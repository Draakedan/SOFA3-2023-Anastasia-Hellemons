using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioscoop
{
    public class MovieScreening
    {
        [JsonProperty]
        private DateTime DateAndTime { get; set; }
        [JsonProperty]
        private double PricePerSeat { get; set; }
        [JsonProperty]
        private Movie Movie { get; set; }

        public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
        {
            this.Movie = movie;
            this.DateAndTime = dateAndTime;
            this.PricePerSeat = pricePerSeat;
        }

        public double GetPricePerSeat()
        {
            return PricePerSeat;
        }

        public override string ToString()
        {
            return Movie.ToString() + " at " + DateAndTime.ToString("dddd, dd MMMM yyyy");
        }
    }
}
