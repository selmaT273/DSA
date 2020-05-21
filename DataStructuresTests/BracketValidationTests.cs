using System;
using DataStructures;
using DataStructures.Stack;
using Xunit;

namespace DataStructuresTests
{
    public class BracketValidationTests
    {
        [Fact]
        public void CanValidateBalancedStringTest()
        {
            BracketValidation bracketValidation = new BracketValidation();

            Assert.True(bracketValidation.MultiBracketValidation("(){}[[]]"));
        }
    }
}
