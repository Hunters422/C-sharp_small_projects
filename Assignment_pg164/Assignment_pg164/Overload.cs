﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg164
{
    public static class Overload
    {
        public static int addMethod(int x, int y)
        {
            int total = x + y;
            return total;
        }


        public static int addMethod(int x, int y, int z)
        {
            int sum = x + y + z;
            return sum;
        }
    }
}
