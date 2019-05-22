using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventHandlingApp.Models
{
    public class Person
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int NationalCode { get; set; }
      
        public ApplicationUser applicationUser { get; set; }
    }
}