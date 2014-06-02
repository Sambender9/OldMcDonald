using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.data.models
{
    public class AnimalFarms
    {
        public int Id                       { get; set; }
        public int FarmId                   { get; set; }
        public int AnimalId                 { get; set; }
        public virtual Animal Animals       { get; set; }
        public virtual Farm Farms           { get; set; }
    }
}
