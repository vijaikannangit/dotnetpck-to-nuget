// Test.cs

using System;
using Xunit;
using library;

namespace library.testing
{
    public class Test
    {
        [Fact]
        public void TestingAdd()
        {
            var start = new Start();
            var actual = start.Add(1, 2);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void TestingSub()
        {
            var start = new Start();
            var actual = start.Sub(1, 2);
            Assert.Equal(-1, actual);
        }
    }
}