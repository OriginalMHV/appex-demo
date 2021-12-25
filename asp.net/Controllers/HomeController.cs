using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp.net.Models;
using ModelOverview.Models;

namespace asp.net.Controllers;

public class HomeController : Controller
{
    [HttpGet]
        public ActionResult Index()
        {
            return View(new OverviewModel());
        }
    public ActionResult Overview()
    {
        OverviewModel overview = new OverviewModel();
        overview.OrganizationId = 0;
        overview.OrganizationName = "";
        overview.OrganizationType = "";
        overview.OrganizationSize = "";
        overview.OrganizationPostalCode = "";
        overview.OrganizationCity = "";
        overview.OrganizationPhoneNumber = "";
        overview.OrganizationEmailAddress = "";
        overview.OrganizationDescription = "";
        overview.OrganizationStartDate = "";
            return Json(overview., JsonRequestBehavior.AllowGet);
    }

    
    
}
