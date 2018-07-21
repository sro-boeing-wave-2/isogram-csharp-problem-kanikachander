using System;
using Xunit;    
using isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void HoldTrueForEmptyString()
        {
            Assert.True(Class1.Isogram(""));
        }

        [Fact]
        public void HoldTrueCase()
        {
            Assert.True(Class1.Isogram("isogram"));
        }

        [Fact]
        public void HoldFalseCase()
        {
            Assert.False(Class1.Isogram("eleven"));
        }

        [Fact]
        public void HoldTrueForLongWords()
        {
            Assert.True(Class1.Isogram("subdermatoglyphic"));
        }

        [Fact]
        public void HoldTrueForMixedCase()
        {
            Assert.True(Class1.Isogram("Alphabet"));
        }

        [Fact]
        public void HoldTrueForHyphen()
        {
            Assert.True(Class1.Isogram("thumbscrew-japingly"));
        }

        [Fact]
        public void HoldTrueForDuplicatedHyphen()
        {
            Assert.True(Class1.Isogram("six-year-old"));
        }

        [Fact]
        public void HoldTrueNamesSeparatedBySpaces()
        {
            Assert.True(Class1.Isogram("ken tabor"));
        }
    }
}
