using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlexyboxTestTask.Tests
{
    [TestClass]
    public class ProgramTests
    {

        private readonly List<Vehicle> _instances
            = new List<Vehicle> { new Bicycle(), new Bus(), new Car(), new AbcVehicle() };

        [TestMethod]
        public void ShouldReturnValidSearchResult()
        {
            //Arrange
            var testValue = "Bicycle";
            //Act
            var bicycle = Program.Search(testValue, _instances).FirstOrDefault();
            //Assert
            Assert.IsInstanceOfType(bicycle, typeof(Bicycle));
        }

        [TestMethod]
        public void ShouldReturnInValidSearchResult()
        {
            //Arrange
            var testValue = "not valid search query";
            //Act
            var instance = Program.Search(testValue, _instances).FirstOrDefault();
            //Assert
            Assert.IsNull(instance);
        }

        [TestMethod]
        public void ShouldReverseString()
        {
            //Arrange
            var testValue = "Lorem ipsum dolor sit amet";
            var charSequence = testValue.Reverse();
            var sb = new StringBuilder();
            foreach (var c in charSequence)
            {
                sb.Append(c);
            }
            //Act
            var reverse = Program.ReverseString(testValue);
            //Assert
            Assert.AreEqual(sb.ToString(), reverse);
        }

        [TestMethod]
        public void ShouldReturnTruePalindromeResult()
        {
            //Arrange
            var testValue = "A man, a plan, a canal, Panama!";
            //Act
            var isPalindrome = Program.IsPalindrome(testValue);
            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void ShouldReturnFalsePalindromeResult()
        {
            //Arrange
            var testValue = "Lorem ipsum dolor sit amet";
            //Act
            var isPalindrome = Program.IsPalindrome(testValue);
            //Assert
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void ShouldReturnValidMissingElements()
        {
            //Arrange
            var testValue = new int[] {4, 6, 9};
            var shouldReturn = new int[] {5, 7, 8};
            //Act
            var result = Program.MissingElements(testValue).ToArray();
            //Assert
            CollectionAssert.AreEqual(shouldReturn, result);
        }

        [TestMethod]
        public void ShouldReturnNoMissingElements()
        {
            //Arrange
            var testValue = new int[] { 2, 3, 4 };
            var shouldReturn = new int[] { };
            //Act
            var result = Program.MissingElements(testValue).ToArray();
            //Assert
            CollectionAssert.AreEqual(shouldReturn, result);
        }

    }
}
