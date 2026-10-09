using EPiServer.Web.Mvc;
using MapDemo.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace MapDemo.Controllers
{
    public class MapPageController : PageController<MapPage>
    {
        public IActionResult Index(MapPage currentPage)
        {
            return View(currentPage);
        }
    }
}
