using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplicationMSDN.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is default Action Method";
        }

        public string Welcome()
        {
            return "This is Welcome Method";
        }
    }
}