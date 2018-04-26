﻿using System.Linq;
using NUnit.Framework;
using Task6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            CollectionAssert.AreEqual(expected, Generator<int>.GenerateSequence(10, 1, 1, (x1, x2) => x1 + x2).ToArray());
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            CollectionAssert.AreEqual(expected, Generator<int>.GenerateSequence(10, 1, 2, (x1, x2) => (6 * x2) - (8 * x1)));
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            var sequence = Generator<double>.GenerateSequence(10, 1, 2, (x1, x2) => x2 + (x1 / x2));

            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expected[i], sequence.ElementAt(i), 0.00000000000001);
            }
        }
    }
}
