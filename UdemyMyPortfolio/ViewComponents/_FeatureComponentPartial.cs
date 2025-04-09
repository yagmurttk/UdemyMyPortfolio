using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        UdemyMyPortfolioContext portfolioContext = new UdemyMyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
