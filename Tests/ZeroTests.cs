using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Common;
using System.Linq;

namespace Tests
{
    public class ZeroTests
    {
        [Fact]
        public void BasicTest()
        {
            ZeroGenerator zg = new ZeroGenerator();
            zg.N = 10;
            Assert.Equal(10, zg.GenerateNumbers().Count());

        }

    }
}
