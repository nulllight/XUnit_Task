using System;

namespace XUnit_Task
{
    class Task
    {
        public static Tuple<double, double>? QuadraticEquation(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return new Tuple<double, double>(x1, x2);
            }
            return null;
        }
    }
}
