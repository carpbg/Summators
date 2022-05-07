using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPosotiveNumbers()
        {
            int result = Summator.Sum(new int[] { 1, 2 }  );
            Assert.AreEqual( 3, result );
            //Assert.That(result == 3);
        }
        [Test]
        public void Test_Sum_OnePosotiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.AreEqual(5, result);
            //Assert.That(result == 3);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int result = Summator.Sum(new int[] { -5, -10 });
            Assert.AreEqual(-15, result);
            //Assert.That(result == 3);
        }

    }
}