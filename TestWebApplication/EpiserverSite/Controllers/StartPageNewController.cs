using EPiServer.Web.Mvc;
using EpiserverSite.Models.Pages;
using System.Web.Mvc;

namespace EpiserverSite.Controllers
{
    public class StartPageNewController : PageController<StartPageNew>
    {
        // GET: StartPageNew
        public ActionResult Index(StartPageNew currentPage)
        {
            return View();
        }
    }
}