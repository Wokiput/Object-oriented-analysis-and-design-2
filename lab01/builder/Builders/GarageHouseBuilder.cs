using builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class GarageHouseBuilder : IHouseBuilder
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
            _house.HasStatue = false;
            _house.HasGarden = false;
            _house.HasGarage = true;
            _house.HasPool = false;
        }
        public House GetResult() => _house;
    }
}
