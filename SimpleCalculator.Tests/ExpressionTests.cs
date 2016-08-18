using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTests
    {
        [TestMethod]
        public void ExpressionEnsureICanCreateAnInstance()
        {
            Expression expressionCommand = new Expression();

            Assert.IsNotNull(expressionCommand);
        }

        [TestMethod]
        public void ExtractingTermsOfExpression()
        {

            //Arrange
            Expression term = new Expression();

            //Act
            int ResultingTerm = term.FirstTerm();

            //Assert
            Assert.IsTrue(ResultingTerm is ); 
        }
    }
}
