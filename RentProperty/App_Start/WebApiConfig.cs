﻿using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RentProperty
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            System.Web.Http.Cors.EnableCorsAttribute cors = new System.Web.Http.Cors.EnableCorsAttribute(origins: "*", headers: "*", methods: "*");
            config.EnableCors(new System.Web.Http.Cors.EnableCorsAttribute(origins: "*", headers: "*", methods: "*"));
            config.EnableCors(cors);

            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
