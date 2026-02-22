using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Models
{
    public abstract class BaseHouse
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public string WallMaterial { get; set; }
        public double Area => Width * Length;
    }
}
