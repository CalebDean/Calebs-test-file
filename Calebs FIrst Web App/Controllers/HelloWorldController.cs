﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calebs_FIrst_Web_App.Controllers
{
    public class HelloWorldController : Controller
    {   //
        // GET: HelloWorld
        public ViewResult Index()
        {
            // return "This is my <b>default</b> action...";
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes is: " + numTimes);
             }
        }
    }
