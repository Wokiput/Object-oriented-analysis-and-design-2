using builder.Models;
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
        public override void AddExtras()
        {
            _house.HasGarage = true;
        }
    }
}
