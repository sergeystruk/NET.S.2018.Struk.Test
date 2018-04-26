using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Task4.Solution;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_Interface()
        {
            double expected = 8.3636363;

            double actual = Calculator.CalculateAverage(values, new AverageMean());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Interface()
        {
            double expected = 8.0;

            double actual = Calculator.CalculateAverage(values, new AverageMedian());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_Delegate()
        {
            double expected = 8.3636363;

            double actual = Calculator.CalculateAverage(values, (doubles) => doubles.Sum()/doubles.Count);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Delegate()
        {
            double expected = 8.0;

            double AverageMedian(List<double> doubles)
            {
                var sortedValues = values.OrderBy(x => x).ToList();
                int n = sortedValues.Count;
                if (n % 2 == 1)
                {
                    return sortedValues[(n - 1) / 2];
                }
                return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
            }

            double actual = Calculator.CalculateAverage(values, AverageMedian);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}