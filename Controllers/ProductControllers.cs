using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3_vuava.Models;
namespace Day3_vuava.Controllers
{
    public class ProductControllers : Controller
    {
        private static List<Product> products = new List<Product>()
        {
            new Product (){ Id = 1, Name = "Product 1", price = "10.00", description = "Description 1", categoryId = 1 },
            new Product (){ Id = 2, Name = "Product 2", price = "20.00", description = "Description 2", categoryId = 2 },
            new Product (){ Id = 3, Name = "Product 3", price = "30.00", description = "Description 3", categoryId = 3 }
        };
        // GET: ProductControlers
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductControlers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductControlers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductControlers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProductControlers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductControlers/Edit/5
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

        // GET: ProductControlers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductControlers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
