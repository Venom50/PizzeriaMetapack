using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzeria.Helpers;

namespace Pizzeria.UnitTests
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailIsValid_ReturnsTrue()
        {
            var result = Helper.CheckIfEmailIsCorrect("test123!$&*-=\\^`~#%'+/?_{}@test.com");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailWithoutAtSign_ReturnsFalse()
        {
            var result = Helper.CheckIfEmailIsCorrect("test123test.com");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailWithoutEnding_ReturnsFalse()
        {
            var result = Helper.CheckIfEmailIsCorrect("test123@test");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailWithoutEndingAfterDot_ReturnsFalse()
        {
            var result = Helper.CheckIfEmailIsCorrect("test123@test.");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailWithoutBeginning_ReturnsFalse()
        {
            var result = Helper.CheckIfEmailIsCorrect("@test.com");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailWithWhiteSpace_ReturnsFalse()
        {
            var result = Helper.CheckIfEmailIsCorrect("test 123@test");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfEmailIsCorrect_EmailIsEmpty_ReturnsFalse()
        {
            var result = Helper.CheckIfEmailIsCorrect("");

            Assert.IsFalse(result);
        }
    }
}
