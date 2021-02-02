using NUnit.Framework;

namespace proj_3_test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(proj_3.Program.Calc(10, 5), Is.EqualTo(50));
        }
    }
}