using FutureValue;
using System;
using Xunit;

namespace Module3Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FutureValueTest()
        {
            FutureValue.Models.FutureValueModel futureValueModel = new FutureValue.Models.FutureValueModel();
            FutureValue.Models.FutureValueModel cal = futureValueModel;
            decimal actual;
            decimal expected = 960;
            actual = cal.Calculate();

            Assert.Equal(expected, actual);
        }
    }
}
