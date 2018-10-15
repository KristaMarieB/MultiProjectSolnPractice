using System;
using HometownZoo.Core.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiProjectSolnPractice.Tests.CoreProject
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        [DataRow("98499")]
        [DataRow("98499-")]
        [DataRow("98499-3412")]
        public void IsValidZipCode_USFormat_ReturnsTrue(string input)
        {

            // Arrange
            // string input1 = "98499";
            // utilizing data row instead of creating multiple methods/variables

            // Act
            bool result = Validator.IsValidUSZipCode(input);


            // Assert
            Assert.IsTrue(result);
            // we could do this: Assert.IsTrue(Validator.IsValidUSZipcode(input));
            // but we'll stick with our structure for now to stay organized
        }
    }
}
