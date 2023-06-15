using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class House
    {
        public Basement Floor { get; set; }
        public List<Walls> Wall { get; set; }
        public Door Gate { get; set; }
        public List<Window> Windows { get; set; }
        public Roof HouseTop { get; set; }

        public House()
        {
            Wall = new List<Walls>();
            Windows = new List<Window>();
        }
    }
}
