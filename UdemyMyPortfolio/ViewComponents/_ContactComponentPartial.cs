using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
