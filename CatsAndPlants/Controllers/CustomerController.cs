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
        // F i e l d s  &  P r o p e r t i e s
        private ICustomerRepository _repository;

        // C o n s t r u c t o r s
        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        // M e t h o d s
        // R E A D
        public IActionResult Index()
        {
            IQueryable<Customer> customers = _repository.GetAllCustomers();
            return View(customers);
        }


        public IActionResult Details(int id)
        {
            Customer c = _repository.GetCustomerById(id);
            return View(c);
        }

        // C R E A T E
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
                _repository.Create(form);
                return RedirectToAction("Details", new { id = form.CustomerId });
            }
            return View();
        }

        // U P D A T E
        [HttpGet]
        public IActionResult EditDetails(int id)
        {
            Customer c = _repository.GetCustomerById(id);
            return View(c);
        }

        [HttpPost]
        public IActionResult EditDetails(Customer updatedDetails)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(updatedDetails);
                return RedirectToAction("Details", new { id = updatedDetails.CustomerId });
            }
            return View(updatedDetails);
        }

        // D E L E T E
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer c = _repository.GetCustomerById(id);
            return View(c);
        }

        [HttpPost]
        public IActionResult Delete(Customer c)
        {
            _repository.Delete(c.CustomerId);
            return RedirectToAction("Index");
        }
    }
}
