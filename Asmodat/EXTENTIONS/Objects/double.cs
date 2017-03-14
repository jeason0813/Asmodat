﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Asmodat.Abbreviate;
using System.Numerics;
using Asmodat.Extensions.Collections.Generic;

namespace Asmodat.Extensions.Objects
{


    public static class doubleEx
    {
        public static double GetSign(this double d)
        {
            if (double.IsNaN(d))
                return double.NaN;
            else if (d == 0)
                return 0;
            else return d > 0 ? 1 : -1;
        }

        public static bool IsNaN(this double d) { return double.IsNaN(d); }


        public static bool TryParse(this string value, out double result)
        {
            if(value.IsNullOrEmpty())
            {
                result = default(double);
                return false;
            }

            return double.TryParse(value, out result);
        }


        public static double TryParse(this string value, double _default)
        {
            if (value.IsNullOrEmpty())
                return _default;

            if (double.TryParse(value, out double result))
                return result;

            return _default;
        }
    }
}
