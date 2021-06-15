using NUnit.Framework;
using User_Registration;

namespace User_TestProject.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        ValidateInput objInputValidate = new ValidateInput();

        [Test]
        public void Test1()
        {
            string firstName = "Siddho";
            string expected = firstName;
            string result = objInputValidate.ValidateName(firstName);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            string firstLast = "Siddho";
            string expected = firstLast;
            string result = objInputValidate.ValidateName(firstLast);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test3()
        {
            string email = "abc.siddh@bl.co.in";
            string expected = email;
            string result = objInputValidate.ValidateEmail(email);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test4()
        {
            string password = "aaaaAa1aa$aa";
            string expected = password;
            string result = objInputValidate.ValidPassword(password);
            Assert.AreEqual(expected, result);
        }
    }
}