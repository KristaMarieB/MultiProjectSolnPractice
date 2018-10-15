using System;
using HometownZoo.Core.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiProjectSolnPractice.Tests.CoreProject
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void IsValidZipCode_USFormat_ReturnsTrue()
        {

            // Arrange
            string input = "98499";

            // Act
            bool result = Validator.IsValidUSZipCode(input);

            // Assert
            Assert.IsTrue(result);
            // we could do this: Assert.IsTrue(Validator.IsValidUSZipcode(input));
            // but we'll stick with our structure for now to stay organized
        }
    }
}
