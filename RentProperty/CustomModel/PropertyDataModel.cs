using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomModel
{
    public class PropertyDataModel
    {
        public int PropertyId { get; set; }
        public string PropertyImage { get; set; }
        public string PropertyName { get; set; }
        public int SquareFts { get; set; }
        public int RentCost { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public decimal Type { get; set; }
        public string LandLordName { get; set; }
        public string LandLordImage { get; set; }
        public int UserId { get; set; }


    }
}