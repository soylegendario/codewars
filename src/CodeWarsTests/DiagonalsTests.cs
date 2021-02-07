using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DiagonalsTests
    {
        [Test]
        public void DiagonalDiffTest_DiffTest ()
        {
            var arr = new List<List<int>> {
                new List<int> {18, 4, 6},
                new List<int> {8, 2, 7},
                new List<int> {21, 9, -13}
            };
            // D1 = 18 + 2 + -13 = 7
            // D2 = 6 + 2 + 21 = 29
            // abs D1 - D2 = 7 - 29 = -22 = 22
            var result = Diagonals.DiagonalsDiff (arr);
            
            Assert.True(result == 22, "The abs diff between diagonal must be 22");
        }

        [Test]
        public void DiagonalDiffTest_ArgumentNull ()
        {
            Assert.Throws<ArgumentException> (() => Diagonals.DiagonalsDiff (null));
        }
        
        [Test]
        public void DiagonalDiffTest_SquareTest ()
        {
            var arr = new List<List<int>> {
                new List<int> {18, 4, 6, 5},
                new List<int> {8, 2, 7},
                new List<int> {21, 9, -13}
            };
            Assert.Throws<ArgumentException> (() => Diagonals.DiagonalsDiff (arr));
        }
        
    }
}