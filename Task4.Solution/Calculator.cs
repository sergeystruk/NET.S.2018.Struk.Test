using System;
using System.Collections.Generic;
using System.Linq;
namespace Task4.Solution
{
    public static class Calculator
    {
        public static double CalculateAverage(List<double> values, Func<List<double>, double> method)
        {
            if (ReferenceEquals(values, null))
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (ReferenceEquals(method, null))
            {
                method = (doubles) => doubles.Sum() / doubles.Count();
            }

            return method(values);
        }

        public static double CalculateAverage(List<double> values, IAveragingMethod method)
        {
            if (ReferenceEquals(values, null))
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (ReferenceEquals(method, null))
            {
                method = new AverageMean();
            }

            return method.AveragingMethod(values);
        }
    }
}