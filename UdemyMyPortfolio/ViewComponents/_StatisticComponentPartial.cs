using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
