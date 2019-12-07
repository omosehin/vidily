using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidil.Models;

namespace vidil.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}