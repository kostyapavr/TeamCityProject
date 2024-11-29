using static TwinPrimes.TwinPrimes;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPrime()
        {
            Assert.That(!isPrime(6));
            Assert.That(isPrime(11));
            Assert.That(isPrime(101));
            Assert.That(!isPrime(66));
        }

        [Test]
        public void TestPairs()
        {
            int num = 1;
            Assert.That(getNextPair(ref num), Is.EqualTo("(5, 7)"));
            Assert.That(getNextPair(ref num), Is.EqualTo("(11, 13)"));
            num = 6;
            Assert.That(getNextPair(ref num), Is.EqualTo("(41, 43)"));
            num = 15;
            Assert.That(getNextPair(ref num), Is.EqualTo("(101, 103)"));
        }
    }
}