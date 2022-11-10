using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomModel
{
    public class ReqResponseModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        public string Place { get; set; }


    }
}