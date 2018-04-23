using System;
using System.Collections.Generic;

namespace Task6.Solution
{
    public static class Generator<T>
    {
        public static IEnumerable<T> GenerateSequence(int size, T first, T second, Func<T, T, T> law)
        {
            if (size < 2)
            {
                throw new ArgumentException(nameof(size));
            }
            
            yield return first;
            yield return second;
            T buffer = first;
            
            for (int i = 2; i < size; i++)
            {
                buffer = second;
                yield return second = law(first, buffer);
                first = buffer;
            }
        }
    }
}