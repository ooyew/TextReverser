using TextReverser.BLL;

namespace TestApplication
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(TestName = "Test true scenario")]
        public void TestReversedString1()
        {
            var result = HelperClass.ReversedString("abcd");
            Assert.That("dcba", Is.EqualTo(result));
        }

        [TestCase(TestName = "Test false scenario")]
        public void TestReversedString2()
        {
            var result = HelperClass.ReversedString("abcd");
            Assert.That("1234", !Is.EqualTo(result));
        }
    }
}