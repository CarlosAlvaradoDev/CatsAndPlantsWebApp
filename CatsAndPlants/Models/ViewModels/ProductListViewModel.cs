using System.Linq;

namespace CatsAndPlants.Models
{
   public class ProductListViewModel // View Model is also called Data Transfer Object - DTO
   {
      //   F i e l d s   &   P r o p e r t i e s

      public IQueryable<Product> Products          { get; set; }

      public PagingInfo          PagingInformation { get; set; }

      public string              CurrentCategory   { get; set; }


      //   C o n s t r u c t o r s


      //   M e t h o d s

   }
}
