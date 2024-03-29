﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omlcs
{
    public class Main
    {
        public static int Floor(float x)
        {
            var n = x.ToString().Split('.');

            return int.Parse(n[0]);
        }

        public static int Round(float x)
        {
            int n;

            if (x % 1 >= 0.5)
            {
                n = Ceil(x);
            }
            else
            {
                n = Floor(x);
            }

            return n;
        }

        public static int Ceil(float x)
        {
            return Floor(x) + 1;
        }
    }
}
