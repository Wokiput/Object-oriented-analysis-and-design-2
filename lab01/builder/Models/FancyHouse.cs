using builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Models
{
    public class FancyHouse : BaseHouse
    {
        public double PoolWidth { get; set; }
        public double PoolLength { get; set; }
        public double GarageWidth { get; set; }
        public double GarageLength { get; set; }
        public string GardenType { get; set; }
        public string StatueType { get; set; }
    }
}
