using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.Builders
{
    public class Director
    {
        public void Construct(BaseHouseBuilder builder, double length, double width, string material)
        {
            builder.BuildBase(width, length, material);
        }
    }
}
