using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.data.models
{
    public class Farm
    {
        public int Id                   { get; set; }
        public string NameOfFarm        { get; set; }
        public string Location          { get; set; }
        public string PictureOfFarm     { get; set; }
        public List<Animal> Animals     { get; set; }
    }
}
