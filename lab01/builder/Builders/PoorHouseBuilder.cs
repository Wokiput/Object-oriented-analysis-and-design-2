using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using builder.Models;

namespace builder.Builders
{
    public class PoorHouseBuilder : BaseHouseBuilder
    {
        private PoorHouse _house = new PoorHouse();
        public override void BuildBase(double width, double length, string material)
        {
            _house.Width = width;
            _house.Length = length;
            _house.WallMaterial = material;
        }
        public PoorHouse GetHouse() => _house;
    }
}
