﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Basement : IPart
    {
        public string PartHouse()
        {
            return "Фундамент";
        }
    }
}
