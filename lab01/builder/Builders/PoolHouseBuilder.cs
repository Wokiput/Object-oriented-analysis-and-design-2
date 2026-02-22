using builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class PoolHouseBuilder : BaseHouseBuilder
    {
        private PoolHouse _house = new PoolHouse();
        public override void BuildBase(double width, double length, string material)
        {
            _house.Width = width;
            _house.Length = length;
            _house.WallMaterial = material;
        }
        public void SetPoolParams(double w, double l)
        {
            _house.PoolWidth = w;
            _house.PoolLength = l;
        }
        public PoolHouse GetHouse() => _house;
    }
}
