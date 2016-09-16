using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void ExpressionEnsureICanCreateAnInstance()
        {
            Expression expression_cmd = new Expression();
            Assert.IsNotNull(expression_cmd);

        }

        [TestMethod]
        public void ExpressionsTesting()
        {
            // Arrange
            Expression expression_cmd = new Expression();
            
            // Act
            string firstTerm = expression_cmd.ExpressionHandler("5");
            
            // Assert
            Assert.AreEqual(firstTerm, 5);
            
        }
    }
}