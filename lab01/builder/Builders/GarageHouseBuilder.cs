using builder.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class GarageHouseBuilder : BaseHouseBuilder
    {
        private GarageHouse _house = new GarageHouse();
        public override void BuildBase(double width, double length, string material)
        {
            _house.Width = width;
            _house.Length = length;
            _house.WallMaterial = material;
        }
        public void SetGarageParams(double w, double l)
        {
            _house.GarageWidth = w;
            _house.GarageLength = l;
        }
        public GarageHouse GetHouse() => _house;
    }
}
