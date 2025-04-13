using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
