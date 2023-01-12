using System;
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
    }
}
