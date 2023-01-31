using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bioscoop
{
    internal class Movie
    {
        private string Title { get; set; }
        private List<MovieScreening> Screenings { get; set; }
        public Movie(string title)
        {
            this.Title = title;
            this.Screenings = new List<MovieScreening>();
        }

        public void AddScreening(MovieScreening screening)
        {
            this.Screenings.Add(screening);
        }

        public override string ToString() => Title;
    }
}
