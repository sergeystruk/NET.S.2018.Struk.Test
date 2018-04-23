using System.Collections.Generic;
using System.Linq;

namespace Task4.Solution
{
    public class AverageMean : IAveragingMethod
    {
        public double AveragingMethod(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}