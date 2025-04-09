using Microsoft.AspNetCore.Mvc;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}