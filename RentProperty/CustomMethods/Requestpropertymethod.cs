using RentProperty.CustomModel;
using RentProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomMethods
{
    public class Requestpropertymethod
    {
        LandLordClassesDataContext Context;


        public Requestpropertymethod()
        {
            Context = new LandLordClassesDataContext();
        }

        public RequestModel Addrequest(RequestModel data)
        {
            try
            {
                Context._requestSp(data.PropertyId,data.UserId);

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }

        public List<ReqResponseModel> GetRequest(int PropertyId)
        {
            List<ReqResponseModel> data = new List<ReqResponseModel>();
            try
            {
                var l = Context._spGetRequest(PropertyId).ToList();
                if (l.Count() > 0)
                {
                    data = l.AsEnumerable().Select(x => new ReqResponseModel
                    {
                        FullName = x.FullName,
                        MobileNumber = (long)x.MobileNumber
                    }).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }

    }

    
}