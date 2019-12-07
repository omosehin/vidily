using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidil.Models;
using vidil.ViewModels;

namespace vidil.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random

        // public ActionResult Random() //action name is random
        public ActionResult Random() //action name is Random,
        {
            var movie = new Movie() { Name = "Tunde" };
            var customer = new List<Customer>
            {
                new Customer{Id=1, Name = "Customer 1"},
                new Customer{ Id =2,Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
                Customers = customer
            };
            return View(viewModel); // pass the movie object


            //  return Content("Hello Nigeria");  //return text
            //  return HttpNotFound(); //not found page

            // return new EmptyResult(); // empty result

            //  return RedirectToAction("Index", "Home"); //redirect to home
            // return RedirectToAction("Index", "Home",new {page = 1,sortBy = "name" }); //redirect to home with some if we want to pass argument to the target action we use an anonymous object as the third argument (params) to this method 


            //return new ViewResult(); //Alternatively to View up there
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        /* movies (Imagine it returns a list of movie in the db) 
         So if pageIndex is not specified we display the movies in page 1
          If sortby is not specify we sort it by name 
          To make params optional we make it nullable
          sring is a reference type and is nullable by default
             */
        //movies
        public ActionResult Index(int? pageIndex, string sortBy) //optional params
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex = {0}&sortBy = {1}", pageIndex, sortBy));
        }

        //  Apply the Route attribute and put the URL template
        //  [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] //multiple constraint //url template //This is template of how you will place the url released = actionname 

        public ActionResult ByReleasedDate(int year, int month) //for the month you can use a byte because the largest number is 12
        {
            return Content(year + "/" + month);
        }
    }
}