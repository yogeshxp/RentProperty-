using Newtonsoft.Json.Linq;
using RentProperty.CustomMethods;
using RentProperty.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentProperty.Controllers
{
    public class RequestPropertyController : ApiController
    {
        Requestpropertymethod requestpropertymethod;

        public RequestPropertyController()
        {
            requestpropertymethod = new Requestpropertymethod();
        }

        [HttpPost]
        [Route("api/sendRequest")]

        public HttpResponseMessage Addrequest(RequestModel data)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            Response<RequestModel> response = new Response<RequestModel>();

            try
            {
               
                var result = requestpropertymethod.Addrequest(data);
                if (result != null)
                {

                    response.Status = true;
                    response.Data = result;
                    response.Message = "Request send successfully";
                }
                else
                {
                    response.Status = false;
                    response.Message = "Request Not send successfully";
                }
            }
            catch (Exception)
            {

                throw;
            }
            responseMessage = Request.CreateResponse(HttpStatusCode.OK, response);
            return responseMessage;
        }

        [HttpGet]
        [Route("api/getrequest")]
        public HttpResponseMessage GetRequest(int PropertyId)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            Response<List<ReqResponseModel>> response = new Response<List<ReqResponseModel>>();
            try
            {
                response.Status = true;
                response.Data = requestpropertymethod.GetRequest(PropertyId);
                response.Message = "Displaying all records";
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
