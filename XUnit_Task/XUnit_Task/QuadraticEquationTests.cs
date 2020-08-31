using System;
using Xunit;
using XUnit_Task;

namespace XUnit_Task
{
    public class QuadraticEquationTests
    {
        [Fact]
        public static void QuadraticEquation_args1_4_1_returned_x1x2()
        {
            double a = 1, b = 4, c = 1;
            double x1 = -0.2679491924311228, x2 = -3.732050807568877;

            Tuple<double, double> res = Tuple.Create(x1, x2);
            Tuple<double, double> actual = Task.QuadraticEquation(a, b, c);

            Assert.Equal(actual, res);
        }

        [Fact]
        public static void QuadraticEquation_args1_0_1_returned_x1x2()
        {
            double a = 1, b = 0, c = 1;

            Tuple<double, double> actual = Task.QuadraticEquation(a, b, c);

            Assert.Null(actual);
        }

        [Fact]
        public static void QuadraticEquation_args1_1_1_returned_x1x2()
        {
            double a = 1, b = 1, c = 1;

            Tuple<double, double> actual = Task.QuadraticEquation(a, b, c);

            Assert.Null(actual);
        }

        [Fact]
        public static void QuadraticEquation_args2_5_3_returned_x1x2()
        {

            double a = 2, b = 5, c = -3.5;
            double x1 = 0.5700274723201295, x2 = -3.0700274723201293;
            Tuple<double, double> res = Tuple.Create(x1, x2);

            Tuple<double, double> actual = Task.QuadraticEquation(a, b, c);

            Assert.Equal(actual, res);
        }
    }
}
