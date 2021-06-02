using CoffeeHouse.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace CoffeeHouse.Controllers
{
    public class ADMINController : Controller
    {
        public IActionResult Index()
        {
            List<Product> allprods = DAL.ReadAllProducts();
            return View(allprods);
        }

        public IActionResult AddProductForm(string id)
        {
            ViewBag.prodid = id;
            return View();
        }
        
        [HttpPost]
        public IActionResult AddProduct(Product produce)
        {
            DAL.AddProduct(produce);
            return RedirectToAction("Index");
        }

        //Grabs the single product to be deleted
        public IActionResult Delete(int id)
        {
            Product prods = DAL.GetSingleProduct(id);
            return View(prods);
        }
        //Actually Deletes once the user confirms
        public IActionResult DeleteConfirm(int id)
        {

            DAL.Delete(id);
            return RedirectToAction("Index");
        }
        
        //Update an existing product
        public IActionResult EditForm(int id)
        {
            Product produce = DAL.GetSingleProduct(id);
            return View(produce);
        }

        [HttpPost]
        public IActionResult Edit(Product produce)
        {
            DAL.EditProduct(produce);
            return RedirectToAction("Index");
        }

    }
}
