using CodeWars;

namespace CodeWarsTests
{
    using NUnit.Framework;
  
    [TestFixture]
    public class PhoneNumberTests
    {
        [Test]
        [TestCase(new int[]{1,2,3,4,5,6,7,8,9,0}, ExpectedResult="(123) 456-7890")]
        [TestCase(new int[]{1,1,1,1,1,1,1,1,1,1}, ExpectedResult="(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return PhoneNumber.CreatePhoneNumber(numbers);
        }
    }

}