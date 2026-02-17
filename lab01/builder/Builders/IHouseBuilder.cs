using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using builder.Models;

namespace builder.Builders
{
    public interface IHouseBuilder
    {
        void BuildBase(double width, double length, string material);
        void AddExtras();
        House GetResult();
    }
}
