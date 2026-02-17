using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class Director
    {
        public void Construct(IHouseBuilder builder, double width, double length, string material)
        {
            builder.BuildBase(width, length, material);
            builder.AddExtras();
        }
    }
}
