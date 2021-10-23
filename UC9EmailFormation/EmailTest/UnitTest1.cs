using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC3RegExEmail;
namespace EmailTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CustomException))]
        public void ValidateEmail()
        {
            //Arrange
            ChkEmail patternMatch = new ChkEmail();
            bool expected = true;

            //Act
            var result = patternMatch.Validate("abc.xyz@bl.co.in");


            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
