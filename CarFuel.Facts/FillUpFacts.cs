using CarFuel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CarFuel.Facts
{
    public class FillUpFacts
    {
        public class GeneralUsage
        {
            [Fact]
            public void Basic()
            {
                //Arrange
                var f1 = new FillUp();
                f1.Odometer = 1000;
                f1.IsFull = true;
                f1.Liters = 50.0;

                //Act
                //Assert
                Assert.Equal(1000, f1.Odometer);
                Assert.Equal(true, f1.IsFull);
                Assert.Equal(50.5, f1.Liters);

            }

            [Fact]
            public void DefaultDateShouldBenow()
            {
                var f = new FillUp();

                DateTime dt = f.Date;

                Assert.Equal(expected: DateTime.Now, actual: dt);
            }
        }
    }
}
