using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace UdemyMyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        UdemyMyPortfolioContext portfolioContext = new UdemyMyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle =portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
