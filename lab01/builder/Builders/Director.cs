using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class Director
    {
        public void Construct(IHouseBuilder builder, double length, double width, string material)
        {
            builder.BuildBase(length, width, material);
            builder.AddExtras();
        }
    }
}
