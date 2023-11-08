using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

using Domain.Entities;

namespace Unit.Domain
{
    public class ExampleUnitTest
    {
        [Fact]
        public void CalculateSum_ReturnsCorrectSum()
        {
            // Arrange
            var exampleEntity = new ExampleEntity();
            
            // Act
            var result = exampleEntity.CalculateSum(2, 3);
            
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void CalculateSum_ReturnsCorrectSum_ForDifferentInputs()
        {
            // Arrange
            var exampleEntity = new ExampleEntity();
            
            // Act
            var result = exampleEntity.CalculateSum(5, 7);
            
            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void CalculateSum_ReturnsCorrectSum_ForZeroInputs()
        {
            // Arrange
            var exampleEntity = new ExampleEntity();
            
            // Act
            var result = exampleEntity.CalculateSum(0, 0);
            
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateSum_ThrowsException_ForNegativeInputs()
        {
            // Arrange
            var exampleEntity = new ExampleEntity();
            
            // Act
            var exception = Assert.Throws<ArgumentException>(() => exampleEntity.CalculateSum(-2, -3));
            
            // Assert
            Assert.Equal("Arguments must be non-negative.", exception.Message);
        }
    }
}