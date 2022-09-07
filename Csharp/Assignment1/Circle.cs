using System;
using System.Collections.Generic;
namespace Assignment1
{
    internal class Circle
    {
        public KeyValuePair<double, double> CalculateAreaCircumference(double radius)
        {
            double area = 0.0, circumference = 0.0;
            area = radius * radius * Math.PI;
            circumference = 2 * Math.PI * radius;
            return new KeyValuePair<double, double>(area, circumference);
        }
    }
}
