using System;

namespace CatsAndPlants.Models
{
   public class PagingInfo
   {
      //   F i e l d s   &   P r o p e r t i e s

      public int TotalItems   { get; set; }
      public int ItemsPerPage { get; set; }
      public int CurrentPage  { get; set; }


      //   C o n s t r u c t o r s


      //   M e t h o d s

      public int TotalPages()
      {
         return (int) Math.Ceiling((double) TotalItems / ItemsPerPage);
      }
   }
}
