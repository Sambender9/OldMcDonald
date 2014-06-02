using Application.data;
using Application.data.models;
using OldMcDonald.web.Adapters.AnimalDataAdapter;
using OldMcDonald.web.Adapters.Interfaces;
using OldMcDonald.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OldMcDonald.web.Controllers
{
    public class HomeController : Controller
    {
        private IAnimalAdapter _adapter;//This forms the agreement/contract with the adapter and we call it IAnimalAdapter

        //this is basically says whenever our home controller is called we are initialzing our adapter!
        public HomeController()
        {
            _adapter = new AnimalDataAdapter();
        }
        //This is for testing and we will always have that warning, not sure why we need it though.
        public HomeController(IAnimalAdapter adapter)
        {
            _adapter = adapter;
        }
        public ActionResult Index()
        {
            return View(_adapter.GetListAnimals());//We pass in the adapter and then we can use our methods with dot notation
        }

        public ActionResult Animal()
        {
            return View();
        }

        public ActionResult Farm()
        {
            return View(_adapter.GetListFarms());
        }
        public ActionResult AnimalDetail(int Id)
        {
            //I want to get the Animal details from the animal class by using an adapter

            return View(_adapter.GetAnimalDetail(Id));//Pass in the Get method to get the animals by id
        }
        [HttpPost]
        public ActionResult AddAnimal(Animal animal)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Animals.Add(animal);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddAnimal()
        {
            AddEditVM model = new AddEditVM();
            model.Title = "Add your Animal";
            model.ButtonMessage = "Add";
            return View(model);
        }
        [HttpGet]
        public ActionResult EditAnimal(int id)
        {
            AddEditVM model = new AddEditVM();
            model.Animal = _adapter.GetAnimal(id);
            model.Title = "Edit Animal" + model.Animal.Name;
            model.ButtonMessage = "Submit Changes";
            return View("AddAnimal", model);
        }
        [HttpPost]
        public ActionResult EditAnimal(Animal animal)
        {
            _adapter.EditAnimal(animal);

            return RedirectToAction("Animal", new { id = animal.Id });
        }
        [HttpGet]
        public ActionResult DeleteAnimal(int Id)
        {
            _adapter.DeleteAnimal(Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddFarm()
        {
            AddEditVM model = new AddEditVM();
            model.Title = "Add your Farm!";
            model.ButtonMessage = "Add";
            return View(model);
        }
        [HttpPost]
        public ActionResult AddFarm(Farm farm)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Farms.Add(farm);
                db.SaveChanges();
            }
            return RedirectToAction("Farm");
        }
        [HttpGet]
        public ActionResult DeleteFarm(int Id)
        {
            _adapter.DeleteFarm(Id);
            return RedirectToAction("Farm");
        }
        public ActionResult AnimalDetails()
        {
            return View();
        }
        public ActionResult FarmDetails()
        {
            return View();
        }
    }
}