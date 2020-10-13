using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.Controllers
{
    internal class RandomMovieviewModel
    {
        public RandomMovieviewModel()
        {
        }

        public Movie Movie { get; internal set; }
        public List<Customer> Customers { get; internal set; }
    }
}