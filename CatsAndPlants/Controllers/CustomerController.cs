using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatsAndPlants.Models;

namespace CatsAndPlants.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer form)
        {
            if (ModelState.IsValid)
            {
               return RedirectToAction("Details", form);
            }
            return View();
        }

        public IActionResult Details(Customer form)
        {
            return View(form);
        }

        [HttpGet]
        public IActionResult EditDetails(int id)
        {
            // Faking out going to the database and getting "id" details.
            Customer charlies = new Customer();
            charlies.CustomerId = id;
            charlies.FirstName = "Charlies";
            charlies.LastName = "Avocado";
            charlies.Email = "c@c.com";
            charlies.Phone = "123";
            charlies.ShipAddress = "123 North";
            charlies.ShipCity = "Phoenix";
            charlies.ShipState = "AZ";
            charlies.ShipPostal = 52234;
            charlies.BillAddress = "123 North";
            charlies.BillCity = "Phoenix";
            charlies.BillState = "AZ";
            charlies.BillPostal = 52234;
            return View(charlies);
        }

        [HttpPost]
        public IActionResult EditDetails(Customer updatedDetails)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Details", updatedDetails);
            }
            return View(updatedDetails);
        }
    }
}
