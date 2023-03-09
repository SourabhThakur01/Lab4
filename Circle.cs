using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * (Radius * Radius);
            }
        } 
        public Circle(double radius)
        {
            if (radius <= 0) 
            {
                throw new InvalidRadiusException();
            }
            Radius = radius;
        }
    }
}
