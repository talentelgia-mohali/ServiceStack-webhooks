using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.RequestDTO;
using WebApplication1.Response;

namespace WebApplication1.Service
{
    public class HelloSrevice: ServiceStack.Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}