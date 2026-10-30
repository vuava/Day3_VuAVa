using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3_vuava.Models;
namespace Day3_vuava.Controllers
{
    public class CategoryController : Controller
    {
        private static List<Category> categories = new List<Category>()
        {
            new Category (){ Id = 1, Name = "Category 1" },
            new Category (){ Id = 2, Name = "Category 2" },
            new Category (){ Id = 3, Name = "Category 3" }
        };
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null) 
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create([FromForm] Category category)
        {
            var ifExistingCategory = categories.FirstOrDefault(c => c.Id == category.Id);
            if (ifExistingCategory != null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                categories.Add(category);
                return RedirectToAction(nameof(Index));
            }

            return View(categories);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit ( Category category )
        {
            var  ifExistingCategory = categories.FirstOrDefault(c => c.Id == category.Id);
            if (ifExistingCategory != null)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                ifExistingCategory.Name = category.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm( int id )
        {
           var category = categories.FirstOrDefault(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            categories.Remove(category);
            return RedirectToAction (nameof(Index));



        }
    }
}
