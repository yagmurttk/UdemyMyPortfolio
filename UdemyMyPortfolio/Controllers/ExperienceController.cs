using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace UdemyMyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        UdemyMyPortfolioContext context = new UdemyMyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
