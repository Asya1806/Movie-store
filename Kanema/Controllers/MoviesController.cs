//using Kanema.Interfaces;
//using Kanema.ViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Kanema.Controllers
//{
//    public class MoviesController : Controller
//    {
//        private readonly IAllMovies _allMovies;
//        private readonly IMoviesCategory _allCategories;

//        public MoviesController(IAllMovies iallMovies, IMoviesCategory imoviesCategory)
//        {
//            _allMovies = iallMovies;
//            _allCategories = imoviesCategory;
//        }

//        public ViewResult List()
//        {
//            ViewBag.Title = "Страница с фильмами";
//            MoviesListViewsModels obj = new MoviesListViewsModels();
//            obj.AllMovies = _allMovies.Movies;
//            obj.currCategory = "Фильмы";
//            return View(obj);
//        }


//        // GET: MoviesController
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: MoviesController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: MoviesController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: MoviesController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: MoviesController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: MoviesController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: MoviesController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: MoviesController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
