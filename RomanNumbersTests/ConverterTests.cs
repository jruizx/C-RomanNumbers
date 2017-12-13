using System;
using RomanNumbers;
using Xunit;

namespace RomanNumbersTests
{
    public class ConverterTests
    {
        [Fact]
        public void Convert()
        {
            var converter = new Converter();

            Assert.Equal("I", converter.Convert(1));
            Assert.Equal("II", converter.Convert(2));
            Assert.Equal("III", converter.Convert(3));
            Assert.Equal("IV", converter.Convert(4));
            Assert.Equal("V", converter.Convert(5));
            Assert.Equal("VI", converter.Convert(6));
            Assert.Equal("VII", converter.Convert(7));
            Assert.Equal("VIII", converter.Convert(8));
            Assert.Equal("IX", converter.Convert(9));
            Assert.Equal("X", converter.Convert(10));
            Assert.Equal("MDCCLXXXV", converter.Convert(1785));
        }
    }
}
