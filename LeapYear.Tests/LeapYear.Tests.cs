using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear.Tests
{
    public class LeapYear
    {
        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(800)]
        [InlineData(1600)]
        [InlineData(2000)]
        [InlineData(2008)]
        [InlineData(2012)]
        [InlineData(2016)]
        public void IsLeapYear_LeapYear_ReturnsTrue(int year)
        {
            Assert.True(Year.IsLeapYear(year));
        }

        [Theory]
        [InlineData(9)]
        [InlineData(100)]
        [InlineData(1500)]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        [InlineData(2017)]
        public void IsLeapYear_NotLeapYear_ReturnsFalse(int year)
        {
            Assert.False(Year.IsLeapYear(year));
        }
    }
}
