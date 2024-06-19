using AuditSystem.Context;
using System.Linq;
using System.Web.Mvc;

namespace AuditSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AuditSystemEntities dbContext = new AuditSystemEntities();

            var dt = dbContext.VW_LegalStatusMaster.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}