﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabaratorWork.Model
{
    public class RegExpr
    {
        public static bool IsNameVld(string name)
        {

            if (string.IsNullOrEmpty(name) || name.Length > 20) { return false; }
            return true;
        }
        public static bool IsPriceVld(double? price)
        {
            Regex regex = new Regex(@"(\d)");
            if (string.IsNullOrEmpty(price.ToString()) || price <= 0 || !regex.IsMatch(price.ToString())) { return false; }
            return true;
        }
        public static bool IsDescVld(string description)
        {
            if (string.IsNullOrEmpty(description) || description.Length > 50) { return false; }
            return true;
        }
    }
}
