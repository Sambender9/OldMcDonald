using Application.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
using Application.data.models;

namespace OldMcDonald.web
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext context, bool createAnimal = true, bool createFarm = true)
        {
            if (createAnimal)
            {
                CreateAnimal(context);
            }
            if (createFarm)
            {
                CreateFarm(context);
            }
        }
        private static void CreateAnimal(ApplicationDbContext context)
        {
            context.Animals.AddOrUpdate(a => a.Name,
                new Animal { Name = "Scarlett Johanson", type = "Horse", PictrueOfAnimal = "http://www.hdwallpaperscool.com/wp-content/uploads/2013/11/arabian-horse-widescreen-images-high-resolution-desktop-wallpapers.jpg", },
                new Animal { Name = "Chad Johnson", type = "Cheetah", PictrueOfAnimal = "http://www.flixya.com/files-photo/b/a/p/bapikaran-2131323.jpg", },
                new Animal { Name = "Steve Smith", type = "Pitbull", PictrueOfAnimal = "https://scontent-a-ord.xx.fbcdn.net/hphotos-xap1/t1.0-9/68376_592627163692_6468923_n.jpg", },
                new Animal { Name = "Cam Newton", type = "Great Dane", PictrueOfAnimal = "http://wallpaperhdhub.com/wp-content/uploads//2014/04/1397438884-Great-Dane-Wallpaper.jpg", },
                new Animal { Name = "Chik Fila", type = "Cow", PictrueOfAnimal = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRk9kMHLMb4xHh4hU74llraHT7dKTNIeLr7ZRBu2ftiJyOZsZi", }
                );
            context.SaveChanges();
        }
        private static void CreateFarm(ApplicationDbContext context)
        {
            context.Farms.AddOrUpdate(f => f.NameOfFarm,
                new Farm { NameOfFarm = "Old McDonald's Farm", Location = "134 Aesthetic Street Williamsville, NY 78964", PictureOfFarm = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQks0cMSMmODPRL0K6wyXwcovj4RfDWGVoiWEqCMVIy8bnXdYuR" },
                new Farm { NameOfFarm = "George Bush's Farm", Location = "999 Amalgamate Lane Checktawoga, NY 78964", PictureOfFarm = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcS6BwOzzZ4co4eRyBS0gQwlnHL5W3z7o_NwAL8_7o2CKdey0DeOWA" },
                new Farm { NameOfFarm = "Sam Bender's Farm", Location = "786 Adulterate Drive Suny, NY 78964", PictureOfFarm = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRxd7oOAdYESTPwT3fJbnYtGULNAU9vkBbz85arwgPAJp5sDzMVdA" },
                new Farm { NameOfFarm = "Sean Mcnary's Farm", Location = "203 Abscond Lane Bronx, NY 78964", PictureOfFarm = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSIGSPzVp5n4lTSQ2JWHLT7MRgq24FDVlRXHIWO9m8dDVGFpTqLtA" },
                new Farm { NameOfFarm = "Old McDonald's Farm", Location = "885 Abate Street East Amherst, NY 78964", PictureOfFarm = "http://www.flash-screen.com/free-wallpaper/100-best-travel-destination-for-easter-day-holiday-wallpaper/farm-reflection-landscape-wallpaper,1366x768,64487.jpg" }
                );
            context.SaveChanges();
        }
    }
}