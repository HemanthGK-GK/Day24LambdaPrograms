using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC13Lambda;

namespace LambdaMStest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class Test
        {
            private readonly RegexPattern User;
            public Test()
            {
                User = new RegexPattern();
            }

            [TestMethod]
            public void validateFirstName()
            {
                var Result = User.ValidateFirstName("Hemanth");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void validateLastName()
            {
                var Result = User.ValidateLastName("Kumar");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void Validate_Email()
            {
                var Result = User.ValidateEmail("hemanth@gmail.com");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void Validate_PhonNum()
            {
                var Result = User.ValidateMobile("91 8965325421");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void Validate_Password()
            {
                var Result = User.ValidatePassword("Manu@71");
                Assert.AreEqual(true, Result);

            }


            [TestMethod]
            public void FirstNameUsingLambdaExpression()
            {
                var Result = User.ValidateFirstName("Vani");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void LastNameUsingLambdaExpression()
            {
                var Result = User.ValidateLastName("Gupta");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void EmailUsingLambdaExpression()
            {
                var Result = User.ValidateEmail("vani@gmail.com");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void MobileNumberUsingLabdaExpression()
            {
                var Result = User.ValidateMobile("91 7854215962");
                Assert.AreEqual(true, Result);
            }

            [TestMethod]
            public void PasswordUingLambdaExpression()
            {
                var Result = User.ValidatePassword("Raj@147");
                Assert.AreEqual(true, Result);
            }
        }
    }
}
