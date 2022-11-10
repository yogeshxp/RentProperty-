using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomModel
{
    public class RequestModel
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }

        public int PropertyId { get; set; }

    }
}