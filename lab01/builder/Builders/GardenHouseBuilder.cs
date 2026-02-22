using builder.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class GardenHouseBuilder : BaseHouseBuilder
    {
        private GardenHouse _house = new GardenHouse();
        public override void BuildBase(double width, double length, string material)
        {
            _house.Width = width;
            _house.Length = length;
            _house.WallMaterial = material;
        }
        public void SetGardenType(string type)
        {
            _house.GardenType = type;
        }
        public GardenHouse GetHouse() => _house;
    }
}
