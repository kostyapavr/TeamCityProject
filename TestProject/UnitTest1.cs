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
        public void TestPrimesTrue()
        {
            Assert.That(isPrime(11));
            Assert.That(isPrime(59));
            Assert.That(isPrime(101));
            Assert.That(isPrime(3));
        }

        [Test]
        public void TestPrimesFalse()
        {
            Assert.That(!isPrime(6));
            Assert.That(!isPrime(105));
            Assert.That(!isPrime(-1));
            Assert.That(!isPrime(81));
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