using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mindbox
{
    internal class Triangle
    {
        internal static double GetSquare(double[] sides)
        {
            Validate(sides);

            var halfP = 0.5 * sides.Sum();
            return Math.Sqrt(
                halfP 
                * (halfP - sides[0]) 
                * (halfP - sides[1]) 
                * (halfP - sides[2])
                );
        }

        internal static bool IsRightTriangle(double[] sides)
        {
            Validate(sides);

            return (sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2])
                || (sides[0] * sides[0] + sides[2] * sides[2] == sides[1] * sides[1])
                || (sides[1] * sides[1] + sides[2] * sides[2] == sides[0] * sides[0]);
        }

        protected static void Validate(double[] sides)
        {
            if (sides.Count() != 3)
                throw new ArgumentException($"Передано неверное колличество сторон треугольника: {sides.Count()}");

            if (!(sides[0] < sides[1] + sides[2] 
                || sides[1] < sides[0] + sides[2] 
                || sides[2] < sides[0] + sides[1]))
            {
                throw new ArgumentException("Треугольник не может состоять из переданных сторон");
            }
        }
    }
}
