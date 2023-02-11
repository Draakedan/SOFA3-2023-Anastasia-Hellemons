using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioscoop
{
    public class MovieTicket
    {
        [JsonProperty]
        private int RowNr { get; set; }
        [JsonProperty]
        private int SeatNr { get; set; }
        [JsonProperty]
        private bool IsPremium { get; set; }
        [JsonProperty]
        public MovieScreening MovieScreening { get; init; }

        public MovieTicket(MovieScreening movieScreening, bool isPremiumReservation, int seatRow, int seatNr)
        {
            this.MovieScreening = movieScreening;
            this.IsPremium = isPremiumReservation;
            this.SeatNr = seatNr;
            this.RowNr = seatRow;
        }

        public bool IsPremiumTicket()
        {
            return this.IsPremium;
        }

        public double GetPrice()
        {
            return this.MovieScreening.GetPricePerSeat();
        }

        public override string ToString()
        {
            return this.MovieScreening.ToString() + " row " + this.RowNr + " seat " + this.SeatNr + "\n\tpremium: " + IsPremium;
        }
    }
}
