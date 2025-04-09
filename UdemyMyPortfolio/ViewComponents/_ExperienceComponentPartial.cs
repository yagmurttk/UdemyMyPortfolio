using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        UdemyMyPortfolioContext portfolioContext = new UdemyMyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
