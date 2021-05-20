using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndPlants.Models
{
    [Table("Order")]
    public class Order
    {
        public int OrderId { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public float TotalCost { get; set; }
        public float Freight { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipPostal { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
