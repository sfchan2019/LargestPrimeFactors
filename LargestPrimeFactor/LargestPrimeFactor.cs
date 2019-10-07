using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    public class LargestPrimeFactor
    {
        public HashSet<long> PrimeMemo = new HashSet<long>();
        public HashSet<long> Dividable = new HashSet<long>();
        public Dictionary<long, long> DividableBy = new Dictionary<long, long>();

        public int CalPrimeNumberDensity(int number)
        {
            return (int)(number / Math.Log(number));
        }

        public bool IsEven(long number)
        {
            return number % 2 == 0;
        }

        public bool IsPrime(int number)
        {
            if (PrimeMemo.Contains(number))
            {
                return true;
            }
            if (number == 2)
            {
                PrimeMemo.Add(number);
                return true;
            }
            else if (IsEven(number))
            {
                return false;
            }

            for (int i = 3; i < Math.Sqrt(number); i+=2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            PrimeMemo.Add(number);
            return true;
        }

        public bool IsPrime(long number)
        {
            if (PrimeMemo.Contains(number))
            {
                return true;
            }
            if (number == 2)
            {
                PrimeMemo.Add(number);
                return true;
            }
            else if (IsEven(number))
            {
                return false;
            }

            for (int i = 3; i < Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            PrimeMemo.Add(number);
            return true;
        }

        public bool DividableByPrimeFactor(long number)
        {
            if (Dividable.Contains(number))
            {
                return true;
            }
            int i = 2;
            while (i < number)
            {
                if (IsPrime(i))
                {
                    if (number % i == 0)
                    {
                        Dividable.Add(number);
                        return true;
                    }
                }
                if (i == 2)
                {
                    i++;
                }
                else
                {
                    i += 2;
                }
            }
            return false;
        }


        public HashSet<long> GetLargestPrimeFactor(long number)
        {
            HashSet<long> memo = new HashSet<long>();
            long i = 2;
            return Helper(number, i, memo);
        }

        public HashSet<long> Helper(long number, long pNum, HashSet<long> memo)
        {
            if (pNum > number)
            {
                return memo;
            }
            if (IsPrime(pNum) && number % pNum == 0)
            {
                memo.Add(pNum);
            }
            if (pNum == 2)
            {
                return Helper(number / pNum, pNum + 1, memo);
            }
            else
            {
                return Helper(number / pNum, pNum + 2, memo);
            }
        }

        //    public bool DividableByPrimeFactor(long number, HashSet<int> memo, int current)
        //    {
        //        int i = current;
        //        while (i < number)
        //        {
        //            if (IsPrime(i) && !memo.Contains(i))
        //            {
        //                if (number % i == 0)
        //                {
        //                    memo.Add(i);
        //                    return true;
        //                }
        //            }
        //            if (i == 2)
        //            {
        //                i++;
        //            }
        //            else
        //            {
        //                i += 2;
        //            }
        //        }
        //        return false;
        //    }
    }
}
