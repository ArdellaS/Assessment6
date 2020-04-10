using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Assessment5.Controllers
{
    public class DishController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public DishController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("partyDB"));
        }
        public ActionResult Index()
        {
            ViewData["Dishes"] = dal.DisplayDishes();
            return View();
        }
        public IActionResult Added(DishInfo dish) 
        {
            int result = dal.AddDish(dish);

            if (result == 1)
            {
                TempData["UserMsg"] = "Dish added";
            }
            else
            {
                TempData["UserMsg"] = "Error. Dish not added";
            }

            return RedirectToAction("Index");
        }
        public IActionResult AddDish()
        {
            DishInfo dish = new DishInfo();

            return View(dish);
        }
        public IActionResult Edit(DishInfo dish)
        {
            int result = dal.EditDishById(dish);

            if (result == 1)
            {
                TempData["Msg"] = "Dish updated";
            }
            else
            {
                TempData["Msg"] = "Error. Dish not updated";
            }
            return RedirectToAction("Index");
        }
        public IActionResult EditDish()
        {
            
            DishInfo dish = new DishInfo();

            return View(dish);
        }
        public IActionResult DeleteDish(int dish)
        {
            int result = dal.DeleteDishById(dish);

            if (result ==1)
            {
                TempData["Msg"] = "Deleted";
            }
            else
            {
                TempData["Msg"] = "Error. Dish not deleted";
            }
            return RedirectToAction("Index");
        }


    }
}