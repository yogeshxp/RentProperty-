using Microsoft.IdentityModel.Tokens;
using RentProperty.CustomModel;
using RentProperty.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace RentProperty.CustomMethods
{
    public class LandLordDataMethod
    {
        LandLordClassesDataContext datacontext;

        public LandLordDataMethod()
        {
            datacontext = new LandLordClassesDataContext();
        }

        public LandLordData Register(LandLordData data)
        {
            try
            {
                datacontext.spRegister(data.FullName, data.Email, data.Password, data.MobileNumber, data.Place, data.ProfileImage);

            }
            catch (Exception)
            {
                throw ;
            }
            return data;
        }

        public LoginResponseModel Login(LandLordData data)
        {
            LoginResponseModel loginResponseModel = new LoginResponseModel();
            try
            {
                var result= datacontext.spLogIn(data.Email, data.Password).FirstOrDefault();
                if (result != null)
                {
                    loginResponseModel.Email = result.Email;
                    loginResponseModel.Password = result.Password;
                    loginResponseModel.UserId=result.UserId;
                    loginResponseModel.FullName=result.FullName;
                    return loginResponseModel;
                    
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}