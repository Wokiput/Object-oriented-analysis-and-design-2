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
        public override void AddExtras()
        {
            _house.HasPool = true;
        }
    }
}
