using Microsoft.AspNetCore.Mvc;
using UdemyMyPortfolio.DAL.Context;
using UdemyMyPortfolio.DAL.Entities;

namespace UdemyMyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        UdemyMyPortfolioContext contex = new UdemyMyPortfolioContext();
        public IActionResult Index()
        {
            var values = contex.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            contex.ToDoLists.Add(toDoList);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var values = contex.ToDoLists.Find(id);
            contex.ToDoLists.Remove(values);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = contex.ToDoLists.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            contex.ToDoLists.Update(toDoList);
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = contex.ToDoLists.Find(id);
            value.Status = true;
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = contex.ToDoLists.Find(id);
            value.Status = false;
            contex.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
