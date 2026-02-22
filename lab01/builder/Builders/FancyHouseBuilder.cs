using builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class FancyHouseBuilder : BaseHouseBuilder
    {
        private FancyHouse _house = new FancyHouse();
        public override void BuildBase(double width, double length, string material)
        {
            _house.Width= width;
            _house.Length= length;
            _house.WallMaterial= material;
        }
        public void SetPoolParams(double w, double l)
        {
            _house.PoolWidth= w;
            _house.PoolLength= l;
        }
        public void SetGarageParams(double w, double l)
        {
            _house.GarageWidth= w;
            _house.GarageLength= l;
        }
        public void SetGardenType(string type) 
        { 
            _house.GardenType = type;
        }
        public void SetStatueType(string type)
        {
            _house.StatueType = type;
        }
        public FancyHouse GetHouse() => _house;
    }
}
