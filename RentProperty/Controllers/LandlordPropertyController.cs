using Newtonsoft.Json.Linq;
using RentProperty.CustomMethods;
using RentProperty.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Web.Http;
using System.Web.UI;

namespace RentProperty.Controllers
{
    public class LandlordPropertyController : ApiController
    {
        landlordpropertyMethod dataMethod;

        public LandlordPropertyController()
        {
            dataMethod = new landlordpropertyMethod();
        }

        [HttpPost]
        [Route("api/addProperty")]

        public HttpResponseMessage AddProperty(PropertyDataModel data)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            Response<PropertyDataModel> response = new Response<PropertyDataModel>();
            try
            {
                response.Status = true;
                response.Data = dataMethod.AddProperty(data);
                response.Message = "Property added successfully";

            }
            catch (Exception)
            {

                throw;
            }
            responseMessage = Request.CreateResponse(HttpStatusCode.OK, response);
            return responseMessage;

        }


        [HttpGet]
        [Route("api/getall")]
        public HttpResponseMessage GetallData(int UserId)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            Response<List<PropertyDataModel>> response = new Response<List<PropertyDataModel>>();
            try
            {
                response.Status = true;
                response.Data = dataMethod.GetallData(UserId);
                response.Message = "Displaying all records";
            }
            catch (Exception)
            {
                throw;
            }
            httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, JObject.FromObject(response));
            return httpResponseMessage;
        }

        [HttpGet]
        [Route("api/getallotherProperty")]
        public HttpResponseMessage GetallOtherData(int UserId)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            Response<List<PropertyDataModel>> response = new Response<List<PropertyDataModel>>();
            try
            {
                response.Status = true;
                response.Data = dataMethod.GetallOtherData(UserId);
                response.Message = "Displaying all records";
            }
            catch (Exception e)
            {
                throw e;
            }
            httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, JObject.FromObject(response));
            return httpResponseMessage;
        }
        [HttpGet]
        [Route("api/getpropertybyid")]
        public HttpResponseMessage GetpropertybyId(int PropertyId)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            Response<List<PropertyDataModel>> response = new Response<List<PropertyDataModel>>();
            try
            {
                response.Status = true;
                response.Data = dataMethod.GetpropertybyId(PropertyId);
                response.Message = "displayed all record by id";

            }
            catch (Exception e)
            {

                throw e;
            }
            httpResponseMessage= Request.CreateResponse(HttpStatusCode.OK, JObject.FromObject(response));
            return httpResponseMessage;
        }
    

        [HttpDelete]
        [Route("api/Delete")]
        public HttpResponseMessage Delete(int PropertyId)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            Response<bool> response = new Response<bool>();
            try
            {
                var result = this.dataMethod.Delete(PropertyId);
                response.Status = true;
                response.Data = (bool)dataMethod.Delete(PropertyId);
                response.Message = "Deletion successful";
            }
            catch (Exception)
            {
                throw;
            }
            responseMessage = Request.CreateResponse(HttpStatusCode.OK, JObject.FromObject(response));
            return responseMessage;
        }


        [HttpPut]
        [Route("api/updateProperty")]
        public HttpResponseMessage updateProperty( PropertyDataModel data)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            Response<PropertyDataModel> response = new Response<PropertyDataModel>();

            try
            {
                response.Status = true;
                response.Data = dataMethod.updateProperty(data);
                response.Message = "Property updated successfully";
            }
            catch (Exception)
            {
                throw;
            }
            httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, JObject.FromObject(response));
            return httpResponseMessage;
        }

    }
}
