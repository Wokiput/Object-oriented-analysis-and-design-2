using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Models
{
    public class House
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public string WallMaterial { get; set; }
        public bool HasPool { get; set; }
        public bool HasGarden { get; set; }
        public bool HasGarage { get; set; }
        public bool HasStatue {  get; set; }
        public double Area => Width * Length;
    }
}
