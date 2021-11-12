using System.Collections.Generic;
using System.Linq;

namespace KataSolutions
{
    public class kyu4_TwiceLinear
    {
        //TODO: Finish it
        public int TwiceLinear(int x)
        //https://www.codewars.com/kata/5672682212c8ecf83e000050
        {
            var results = new List<int>() { 1 };
            var arguments = new List<int>() { 1 };

            for (int i = 1; i <= x; i++)
            {
                var y = 2 * arguments.First() + 1;
                var z = 3 * arguments.First() + 1;
                results.Add(y);
                results.Add(z);
                arguments.Add(y);
                arguments.Add(z);
                arguments.RemoveAt(0);
                arguments.OrderBy(i => i);
            }

            return results.Distinct().OrderBy(i => i).ElementAt(x);
        }
    }
}
