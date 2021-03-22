using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Rot13Tests
    {
        [Test, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", Rot13.Translate("test"), string.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Rot13.Translate("test")));
        }
    
        [Test, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", Rot13.Translate("Test"), string.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Rot13.Translate("Test")));
        }
    }
}