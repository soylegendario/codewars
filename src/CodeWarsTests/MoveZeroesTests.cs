using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MoveZeroesTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual (new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0},
                MoveZeroes.Do (new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
        }        
    }
}