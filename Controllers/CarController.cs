using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {

        [HttpGet("/car")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/car/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/car")]
        public ActionResult Create()
        {
          Car newCar = new Car (int.Parse(Request.Form["price"]), int.Parse(Request.Form["miles"]), Request.Form["make-model"]);
          newCar.Save();
          List<Car> allCars = Car.GetAll();
          return View("Index", allCars);
        }

        [HttpPost("/car/delete")]
        public ActionResult DeleteAll()
        {
            Car.ClearAll();
            return View();
        }

    }
}
