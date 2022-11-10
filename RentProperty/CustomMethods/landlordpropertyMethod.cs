using RentProperty.CustomModel;
using RentProperty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentProperty.CustomMethods
{
    public class landlordpropertyMethod
    {
        LandLordClassesDataContext context;

        public landlordpropertyMethod()
        {
            context = new LandLordClassesDataContext();
        }

        public PropertyDataModel AddProperty(PropertyDataModel data)
        {
            try
            {
                context._propertyinfo(data.PropertyImage, data.PropertyName, data.SquareFts, data.RentCost, data.City, data.Location, (double?)data.Type, data.LandLordName,data.LandLordImage, data.UserId);  
            }
            catch (Exception)
            {

                throw;
            }
            return data;

        }


        public List<PropertyDataModel> GetallData()
        {
            List<PropertyDataModel> data = new List<PropertyDataModel>();
            try
            {
                var l = context._getallProperty().ToList();
                if(l.Count() > 0)
                {
                    data = l.AsEnumerable().Select(x => new PropertyDataModel
                    {
                        PropertyId = x.PropertyId,
                        PropertyImage = x.PropertyImage,
                        PropertyName = x.PropertyName,
                        SquareFts = x.SquareFts,
                        RentCost = x.RentCost,
                        City = x.City,
                        Location = x.Location,
                        Type = (decimal)x.Type,
                        LandLordName = x.LandLordName,
                        UserId = x.UserId


                    }).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }


        public List<PropertyDataModel> GetallOtherData(int UserId)
        {
            List<PropertyDataModel> data = new List<PropertyDataModel>();
            try
            {
                var l = context._getOtherUserProperty(UserId).ToList();
                if (l.Count() > 0)
                {
                    data = l.AsEnumerable().Select(x => new PropertyDataModel
                    {
                        PropertyId = x.PropertyId,
                        PropertyImage = x.PropertyImage,
                        PropertyName = x.PropertyName,
                        SquareFts = x.SquareFts,
                        RentCost = x.RentCost,
                        City = x.City,
                        Location = x.Location,
                        Type = (decimal)x.Type,
                        LandLordName = x.LandLordName


                    }).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }



        public bool Delete(int PropertyId)
        {
            try
            {
                context._deleteProperty(PropertyId);

            }
            catch (Exception)
            {

                throw;
            }
            return true;

        }

        public PropertyDataModel updateProperty( PropertyDataModel data)
        {
            long? result = 0;
            try
            {
                context._updateProperty(data.PropertyId,data.PropertyImage, data.PropertyName, data.SquareFts, data.RentCost, data.City, data.Location, (double?)data.Type, data.LandLordName, ref result);

            }
            catch (Exception)
            {

                throw;
            }
            return data;

        }

        public List<PropertyDataModel> GetpropertybyId( int PropertyId)
        {
            List<PropertyDataModel> data = new List<PropertyDataModel>();
            try
            {
                var l = context._getPropertybyid(PropertyId).ToList();
                if (l.Count() > 0)
                {
                    data = l.AsEnumerable().Select(x => new PropertyDataModel
                    {
                        PropertyId = x.PropertyId,
                        PropertyImage = x.PropertyImage,
                        PropertyName = x.PropertyName,
                        SquareFts = x.SquareFts,
                        RentCost = x.RentCost,
                        City = x.City,
                        Location = x.Location,
                        Type = (decimal)x.Type,
                        LandLordName = x.LandLordName,
                        UserId = x.UserId,


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