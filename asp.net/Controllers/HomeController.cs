using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp.net.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
namespace asp.net.Controllers
{


public class HomeController : Controller
{
    public ActionResult Index()
        {
            ModelOverview model = new ModelOverview();
            ViewData["ModelOverview"] = model.GetModelOverview();
            model.GetModelOverview().Wait();
            return View();
        }
}

}