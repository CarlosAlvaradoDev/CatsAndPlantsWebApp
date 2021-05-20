using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatsAndPlants.Models
{
    public class Customer
    {
        
        

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a Password.")]
        [MinLength(6, ErrorMessage = "Please enter a Password between 6 and 15 characters.")]
        public string Password { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Display(Name = "ShipAdress")]
        [Required(ErrorMessage = "Please enter your address.")]
        public string ShipAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter your city.")]
        public string ShipCity { get; set; }

        [Display(Name = "ShipState")]
        [Required(ErrorMessage = "Please enter your state.")]
        public string ShipState { get; set; }

        [Display(Name = "Postal")]
        [Required(ErrorMessage = "Please enter your postal code.")]
        public int ShipPostal { get; set; }

        [Display(Name = "BillAddress")]
        [Required(ErrorMessage = "Please enter your billing address.")]
        public string BillAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter your city.")]
        public string BillCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter your state.")]
        public string BillState { get; set; }

        [Display(Name = "Postal")]
        [Required(ErrorMessage = "Please enter your postal code.")]
        public int BillPostal { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public int CustomerId { get; set; }

    }
}
