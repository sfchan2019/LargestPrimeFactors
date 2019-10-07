using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LargestPrimeFactor;

namespace LargestPrimeFactor.Test
{
    [TestFixture]
    class LargestPrimeNumber
    {
        LargestPrimeFactor lpf = new LargestPrimeFactor();
        [Test]
        public void PrimberNumberDensityTest()
        {
            Assert.AreEqual(4, lpf.CalPrimeNumberDensity(10));
            Assert.GreaterOrEqual(0, lpf.CalPrimeNumberDensity(-10));
        }

        [Test]
        public void EvenNumberTest()
        {
            Assert.AreEqual(true, lpf.IsEven(10));
        }

        [Test]
        public void PrimeNumberTest()
        {
            Assert.AreEqual(true, lpf.IsPrime(157));
            Assert.AreEqual(true, lpf.IsPrime(2));
            Assert.AreEqual(false, lpf.IsPrime(155));
            Assert.AreEqual(true, lpf.IsPrime(199));
        }

        [Test]
        public void DividableByPrimeFactorTest()
        {
            Assert.AreEqual(true, lpf.DividableByPrimeFactor(13195));
        }

        [Test]
        public void GetLargestPrimeFactorTest()
        {
            //Assert.AreEqual(0, (long)13195 % (long)3);
            Assert.AreEqual(new HashSet<int>(){5,7,13,29 }, lpf.GetLargestPrimeFactor(13195));
            //Assert.AreEqual(new HashSet<int>() { 71,839,1471,6857 }, lpf.GetLargestPrimeFactor(600851475143));
        }

        [Test]
        public void DividableByUncheckedPrimeFactorTest()
        {
            //Assert.AreEqual(true, lpf.DividableByPrimeFactor(13195, new HashSet<int>() { 5, 7 }));
        }
    }
}
