using Application.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMcDonald.web.Adapters.Interfaces
{
    public interface IAnimalAdapter
    {
        List<Animal> GetListAnimals();
        List<Farm> GetListFarms();
        void AddAnimal(Animal animal);
        void EditAnimal(Animal animal);
        void DeleteAnimal(int id);
        Animal GetAnimalByName(string Animal);//not really sure what I'm trying to accomplish here.
        void AddFarm(Farm farm);
        void EditFarm(Farm farm);
        void DeleteFarm(int id);
        Animal GetAnimal(int id);
        Animal GetAnimalDetail(int id);
        Farm GetFarmDetail(int id);
    }
}
