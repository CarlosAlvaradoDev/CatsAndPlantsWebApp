using CatsAndPlants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Controllers
{
    public class HomeController : Controller
    {
        //Fields / Props
        private IProductRepository _repository;

        //Constructors
        public HomeController(IProductRepository repository)
        {
            _repository = repository;
        }

        //Methods
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Plants()
        {
            IQueryable<Product> plantProducts = _repository.GetAllProducts().Where(p => p.Category == "Plants");
            return View(plantProducts);
        }

        public IActionResult Vivariums()
        {
            IQueryable<Product> vivariumProducts = _repository.GetAllProducts().Where(p => p.Category == "Vivariums");
            return View(vivariumProducts);
        }

        public IActionResult Stands()
        {
            IQueryable<Product> standProducts = _repository.GetAllProducts().Where(p => p.Category == "Stands");
            return View(standProducts);
        }

        public IActionResult Supplies()
        {
            IQueryable<Product> supplyProducts = _repository.GetAllProducts().Where(p => p.Category == "Supplies");

            return View(supplyProducts);
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Maintenance()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
