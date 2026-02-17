using builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class GardenHouseBuilder : IHouseBuilder
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
            _house.HasPool = false;
            _house.HasGarage = false;
            _house.HasStatue = false;
        }
        public House GetResult() => _house;
    }
}
