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
    public class LandlordController : ApiController
    {
        LandLordDataMethod dataMethod;

        LandlordController()
        {
            dataMethod = new LandLordDataMethod();
        }

        [HttpPost]
        [Route("api/register")]

        public HttpResponseMessage Register(LandLordData data)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            Response<LandLordData> response = new Response<LandLordData>();
            try
            {
                response.Status = true;
                response.Data = dataMethod.Register(data);
                response.Message = "User Registered successfully";

            }
            catch (Exception)
            {

                throw;
            }
            responseMessage = Request.CreateResponse(HttpStatusCode.OK, response);
            return responseMessage;

        }

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LandLordData data)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            Response<LoginResponseModel> response = new Response<LoginResponseModel>();
            try
            {

              
                var result = dataMethod.Login(data);
                if (result!=null)
                {
                    response.Message = "Login success";
                    response.Data = result;
                    response.Status = true;

                }
                else
                {
                    response.Status = false;
                    response.Message = "Login Failed";
                }
            }
            catch (Exception)
            {

                throw;
            }
            responseMessage = Request.CreateResponse(HttpStatusCode.OK, response);
            return responseMessage;

        }


    }
}
