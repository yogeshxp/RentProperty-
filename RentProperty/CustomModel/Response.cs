using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomModel
{
    public class Response<X>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public X Data { get; set; }
    }
}