using System;
using TriangleSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEquilateralTriangle()
        {
            int side1 = 5, side2 = 5, side3 = 5;
            var result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.AreEqual("Equilateral triangle", result);  // Match the string exactly as returned by the method
        }

        [TestMethod]
        public void AnalyzeTriangle_Isosceles_ReturnsIsosceles_Case1()
        {
            // Arrange.
            int side1 = 4, side2 = 6, side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Isosceles_ReturnsIsosceles_Case2()
        {
            // Arrange
            int side1 = 7, side2 = 5, side3 = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Isosceles_ReturnsIsosceles_Case3()
        {
            // Arrange
            int side1 = 5, side2 = 3, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Scalene_ReturnsScalene_Case1()
        {
            // Arrange.
            int side1 = 2, side2 = 3, side3 = 4;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Scalene_ReturnsScalene_Case2()
        {
            // Arrange
            int side1 = 4, side2 = 5, side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Scalene_ReturnsScalene_Case3()
        {
            // Arrange
            int side1 = 6, side2 = 7, side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Scalene_ReturnsScalene_Case4()
        {
            // Arrange
            int side1 = 8, side2 = 9, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_Scalene_ReturnsScalene_Case5()
        {
            // Arrange
            int side1 = 4, side2 = 5, side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [TestMethod]
        public void AnalyzeTriangle_ZeroSideLength_ReturnsInvalid_Case1()
        {
            // Arrange
            int side1 = 0, side2 = 2, side3 = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }
        [TestMethod]
        public void AnalyzeTriangle_ZeroSideLength_ReturnsInvalid_Case2()
        {
            // Arrange
            int side1 = 0, side2 = 7, side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }
        [TestMethod]
        public void AnalyzeTriangle_ZeroSideLength_ReturnsInvalid_Case3()
        {
            // Arrange
            int side1 = 5, side2 = 0, side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }
        [TestMethod]
        public void AnalyzeTriangle_InvalidTriangle_ReturnsInvalid_Case1()
        {
            // Arrange
            int side1 = 3, side2 = 4, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }
        [TestMethod]
        public void AnalyzeTriangle_InvalidTriangle_ReturnsInvalid_Case2()
        {
            // Arrange
            int side1 = 3, side2 = 3, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }
        [TestMethod]
        public void AnalyzeTriangle_InvalidTriangle_ReturnsInvalid_Case3()
        {
            // Arrange
            int side1 = 1, side2 = 7, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }
    }




}

