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
        public override void AddExtras()
        {
            _house.HasGarden = true;
            _house.HasGarage = true;
            _house.HasPool = true;
            _house.HasStatue = true;
        }
    }
}
