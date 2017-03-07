﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkoTestausDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace YksikkoTestausDemo.Program.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {//AAA-Periaate
            //arrange = Alustus/valmistelu
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 8;
            int expected = 13;
            //act = toimi
            int actual = calc.Add(n1, n2);
            //Assert = Tarkista
            Assert.AreEqual(expected, actual);
        
            
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //AAA-Periaate
             //arrange = Alustus/valmistelu
                Calculator calc = new Calculator();
                int n1 = 5;
                int n2 = 8;
                int expected = 40;
                //act = toimi
                int actual = calc.Multiply(n1, n2);
                //Assert = Tarkista
                Assert.AreEqual(expected, actual);
            }
        public void SubstractTest()
        {
            //AAA-Periaate
            //arrange = Alustus/valmistelu
            Calculator calc = new Calculator();
            int n1 = 10;
            int n2 = 5;
            int expected = 5;
            //act = toimi
            int actual = calc.Substract(n1, n2);
            //Assert = Tarkista
            Assert.AreEqual(expected, actual);
        }
        public void DivideTest()
        {
            //AAA-Periaate
            //arrange = Alustus/valmistelu
            Calculator calc = new Calculator();
            int n1 = 10;
            int n2 = 5;
            int expected = 2;
            //act = toimi
            int actual = calc.Divide(n1, n2);
            //Assert = Tarkista
            Assert.AreEqual(expected, actual);
        }
    }
}