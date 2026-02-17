using builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class FancyHouseBuilder : IHouseBuilder
    {
        private House _house = new House();
        public void BuildBase(double width, double length, string material)
        {
            _house.Width = width;
            _house.Length = length;
            _house.WallMaterial = material;
        }
        public void AddExtras()
        {
            _house.HasGarden = true;
            _house.HasGarage = true;
            _house.HasPool = true;
            _house.HasStatue = true;
        }
        public House GetResult() => _house;
    }
}
