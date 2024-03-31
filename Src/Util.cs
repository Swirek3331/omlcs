﻿using System;
using System.IO;

namespace Omlcs
{
    public class Util
    {
        public static int Floor(float x)
        {
            int rest = (int)(x % 1);
            int n = (int)(x - rest);

            return n;
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

        public static string RootPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.Parent!.FullName;
        }

        public static int Next(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }

        public static int Next(int max)
        {
            return Next(0, max);
        }

        public static float Random()
        {
            Random random = new Random();

            return (float)random.NextDouble();
        }
    }
}
