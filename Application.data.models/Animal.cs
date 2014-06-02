using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.data.models
{
    public class Animal
    {
        public int Id                   { get; set; }
        public string Name              { get; set; }
        public string type              { get; set; }
        public string PictrueOfAnimal   { get; set; }
        public List<Farm> Farms         { get; set; } 
    }
}
