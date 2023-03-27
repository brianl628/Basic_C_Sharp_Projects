using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

public class HomeController : System.Web.Mvc.Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        ViewData("Message") = "Your application description page.";

        return View();
    }

    public ActionResult Contact()
    {
        ViewData("Message") = "Your contact page.";

        return View();
    }
}
