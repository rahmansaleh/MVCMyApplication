using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMyApplication.Controllers
{
    public class DashboardController : Controller
    {
        public String Index()
        {
            return "hello this is a text from Dashboard Controller";
        }

        public int showNum()
        {
            return 2019;
        }
    }
}
