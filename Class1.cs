using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace Testclass
{
    public class Class1
    {
        [Test]
        public void AnalyzeTriangle_EqualateralTriangle_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }


        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle1_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle2_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 9;
            int thirdSide = 9;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle3_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 8;
            int thirdSide = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }


        [Test]
        public void AnalyzeTriangle_ScaleneTriangle1_ReturnsScalene()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 9;
            int thirdSide = 12;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle2_ReturnsScalene()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 6;
            int thirdSide = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle3_ReturnsScalene()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 15;
            int thirdSide = 12;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle4_ReturnsScalene()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 8;
            int thirdSide = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle5_ReturnsScalene()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 14;
            int thirdSide = 12;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLength1_ReturnsInvalidResponse()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 4;
            int thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLength2_ReturnsInvalidResponse()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 0;
            int thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLength3_ReturnsInvalidResponse()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse1_ReturnsInvalidResponse()
        {
            // Arrange
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse2_ReturnsInvalidResponse()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 10;
            int thirdSide = 20;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidResponse3_ReturnsInvalidResponse()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 4;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", result);
        }



    }
}
