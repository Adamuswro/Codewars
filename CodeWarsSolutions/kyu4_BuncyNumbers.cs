﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class kyu4_BuncyNumbers
    {
        public BigInteger BuncyNumbers(int pow)
        //https://www.codewars.com/kata/5672682212c8ecf83e000050
        {
            BigInteger result = 0;
            int[] number = new int[pow];
            while (number.All(n => n == 5))
            {

            }

            return result * 2;
        }
    }
}
