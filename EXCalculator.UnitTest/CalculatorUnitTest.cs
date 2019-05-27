using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EXCalculator.UnitTest
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Calculator();
            
        }

        [TestCase(0,0)]
        public void Add_Add0And0_Return0(double a, double b)
        {
            //Act
            
            //Assert
            Assert.That(_uut.Add(a,b), Is.EqualTo(0));
           
        }

        [TestCase(0, 1, 1)]
        [TestCase(10, -2, 8)]
        [TestCase(-10, 2, -8)]
        [TestCase(-20, -4, -24)]
        public void Add_AddaAndb_ReturnCorrectResult(double a, double b, double c)
        {
            //Act

            //Assert
            Assert.That(_uut.Add(a, b), Is.EqualTo(c));

        }


        [TestCase(0, 0, 0)]
        [TestCase(10, -2, 12)]
        [TestCase(10, 2, 8)]
        [TestCase(-20, -4, -16)]
        public void Substract_SubstractaAndb_ReturnCorrectResult(double a, double b, double c)
        {
            //Act

            //Assert
            Assert.That(_uut.Substract(a, b), Is.EqualTo(c));

        }

        [TestCase(0, 0, 0)]
        [TestCase(10, -2, -20)]
        [TestCase(10, 2, 20)]
        [TestCase(-2, -4, 8)]
        public void Multiply_multiplyaAndb_ReturnCorrectResult(double a, double b, double c)
        {
            //Act

            //Assert
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(c));

        }

        [TestCase(0, 0, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, 3, -8)]
        [TestCase(1, 5, 1)]

        public void Power_powerxAndy_ReturnCorrectResult(double x, double y, double c)
        {
            //Act

            //Assert
            Assert.That(_uut.Power(x, y), Is.EqualTo(c));

        }

       
    }
}
