using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mindbox
{
    internal class Circle
    {
        internal static double GetSquare(double radius)
        {
            Validate(radius);

            return Math.PI * (radius * radius);
        }

        protected static void Validate(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус круга не может быть отрицательным");
        }
    }
}
