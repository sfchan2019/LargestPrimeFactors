using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    public class LargestPrimeFactor
    {
        public int CalPrimeNumberDensity(int number)
        {
            return (int)(number / Math.Log(number));
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsPrime(int number)
        {
            if (number == 2)
            {
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
            return true;
        }

        public bool DividableByPrimeFactor(int number)
        {
            int i = 2;
            while (i < number)
            {
                if (IsPrime(i))
                {
                    if (number % i == 0)
                    {
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

        public HashSet<int> GetLargestPrimeFactor(long number)
        {
            HashSet<int> memo = new HashSet<int>();
            while (DividableByPrimeFactor(number, memo, 2))
            {
                
            }
            return memo;
        }

        public bool DividableByPrimeFactor(long number, HashSet<int> memo, int current)
        {
            int i = current;
            while (i < number)
            {
                if (IsPrime(i) && !memo.Contains(i))
                {
                    if (number % i == 0)
                    {
                        memo.Add(i);
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
    }
}
