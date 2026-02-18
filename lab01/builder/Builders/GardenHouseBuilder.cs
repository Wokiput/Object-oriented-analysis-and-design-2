using builder.Models;
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
        public override void AddExtras()
        {
            _house.HasGarden = true;
        }
    }
}
