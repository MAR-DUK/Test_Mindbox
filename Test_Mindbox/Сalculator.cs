
namespace Test_Mindbox
{
    public class Сalculator
    {
        public static double GetSquare(double[] lines)
        {
            try
            {
                switch (lines.Length)
                {
                    case 1: return Circle.GetSquare(lines[0]);

                    case 3: return Triangle.GetSquare(lines);

                    default:
                        throw new ArgumentException("Передано неверное количество заничений");
                }
            }
            catch(Exception ex)
            {
                string message = "Ошибка при расчете площади фигуры";

                throw new Exception(message, ex);
            }
        }

        public static bool IsRightTriangle(double[] sides) => Triangle.IsRightTriangle(sides);
    }
}