﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear.Tests
{
    public class LeapYear
    {
        [Fact]
        public void IsLeapYear_Year4_ReturnsTrue()
        {
            //arrange
            var year = 4;

            //act
            var checkedYear = Year.IsLeapYear(year);

            //asert
            Assert.True(checkedYear);
        }

        [Fact]
        public void IsLeapYear_Year8_ReturnsTrue()
        {
            //arrange
            var year = 8;

            //act
            var checkedYear = Year.IsLeapYear(year);

            //asert
            Assert.True(checkedYear);
        }

        [Fact]
        public void IsLeapYear_Year9_ReturnsFalse()
        {
            //arrange
            var year = 9;

            //act
            var checkedYear = Year.IsLeapYear(year);

            //asert
            Assert.False(checkedYear);
        }

        [Fact]
        public void IsLeapYear_Year1700_ReturnsFalse()
        {
            //arrange
            var year = 1700;

            //act
            var checkedYear = Year.IsLeapYear(year);

            //assert
            Assert.False(checkedYear);
        }

        [Fact]
        public void IsLeapYear_Year1500_ReturnsFalse()
        {
            //arrange
            var year = 1500;

            //act
            var checkedYear = Year.IsLeapYear(year);

            //assert
            Assert.False(checkedYear);
        }
    }
}
