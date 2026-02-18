using builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public abstract class BaseHouseBuilder : IHouseBuilder
    {
        protected House _house = new House();
        public virtual void BuildBase(double width, double length, string material)
        {
            _house.Width = width;
            _house.Length = length;
            _house.WallMaterial = material;
        }
        public abstract void AddExtras();
        public House GetResult() { House finishedHouse = _house; return finishedHouse; }
    }
}
