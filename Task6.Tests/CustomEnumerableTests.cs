using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        [Test]
        public void Generator_ForSequence3()
        {

        }
    }
}
