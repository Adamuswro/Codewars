using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    class Which_are_in
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1.Where(s => array2.Any(p => p.Contains(s))).OrderBy(v=>v).ToArray();
        }
    }
}
