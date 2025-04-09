using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        UdemyMyPortfolioContext portfolioContext = new UdemyMyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
