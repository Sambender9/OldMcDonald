using Application.data;
using Application.data.models;
using OldMcDonald.web.Adapters.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;

namespace OldMcDonald.web.Adapters.AnimalDataAdapter
{
    public class AnimalDataAdapter : IAnimalAdapter
    {
        public List<Animal> GetListAnimals()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
               return db.Animals.ToList();
            }
        }
        public List<Farm> GetListFarms()
        {
            List<Farm> model = new List<Farm>();
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Farms.ToList();
            }
            return model;
        }
        public void AddAnimal(Animal animal)
        {
           using (ApplicationDbContext db = new ApplicationDbContext())
           {
               db.Animals.Add(animal);
               db.SaveChanges();
           }
        }
        public void EditAnimal(Animal animal)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Animal model = db.Animals.Find(animal.Id);
                model.Name = animal.Name;
                model.PictrueOfAnimal = animal.PictrueOfAnimal;
                db.SaveChanges();
            }
        }
        public Animal GetAnimal(int id)
        {
            Animal animal = new Animal();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                animal = db.Animals.Include("Animals").Where(x => x.Id == id).FirstOrDefault();
            }
            return animal;
        }
        public void DeleteAnimal(int id)
        {
           using(ApplicationDbContext db = new ApplicationDbContext())
           {
                Animal animal = db.Animals.Find(id);
                db.Animals.Remove(animal);
                db.SaveChanges();
           }
        }

        public Animal GetAnimalByName(string animal)
        {
            {
            Animal model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Animals.Include("Animals").Where(t => t.Name == animal).FirstOrDefault();
            };
            return model;
            }
        }
        public void Addfarm(Farm farm)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Farms.Add(farm);
                db.SaveChanges();
            }
        }
        public void EditFarm(Farm farm)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Farm model = db.Farms.Find(farm.Id);
                model.NameOfFarm = farm.NameOfFarm;
                model.PictureOfFarm = farm.PictureOfFarm;
                db.SaveChanges();
            }
        }
        public void DeleteFarm(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Farm farm = db.Farms.Find(id);
                db.Farms.Remove(farm);
                db.SaveChanges();
            }
        }
        public Animal GetAnimalDetail(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return (db.Animals.Find(id));
            }
           
        }


        public void AddFarm(Farm farm)
        {
            throw new NotImplementedException();
        }

        public Farm GetFarmDetail(int id)
        {
            throw new NotImplementedException();
        }
    }
}