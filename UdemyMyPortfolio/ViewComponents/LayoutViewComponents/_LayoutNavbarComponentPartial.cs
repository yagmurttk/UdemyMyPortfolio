using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;

namespace UdemyMyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        UdemyMyPortfolioContext context = new UdemyMyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count(); //yapılmamış olan yada okunmamış bildirim sayısını verir
            var values = context.ToDoLists.Where(x => x.Status == false).ToList(); //yapılmamış olan yada okunmamış bildirimleri listeler
            return View(values);
        }
    }
}

