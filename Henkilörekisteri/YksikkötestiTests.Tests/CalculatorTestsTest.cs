// <copyright file="CalculatorTestsTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkoTestausDemo.Program.Tests;

namespace YksikkoTestausDemo.Program.Tests.Tests
{
    /// <summary>This class contains parameterized unit tests for CalculatorTests</summary>
    [PexClass(typeof(CalculatorTests))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CalculatorTestsTest
    {
        /// <summary>Test stub for DivideTest()</summary>
        [PexMethod]
        public void DivideTestTest([PexAssumeUnderTest]CalculatorTests target)
        {
            target.DivideTest();
            // TODO: add assertions to method CalculatorTestsTest.DivideTestTest(CalculatorTests)
        }
    }
}
