using System;
using Xunit;

namespace GithubActionsTest.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessfulTest()
        {
            var result = 1;
            Assert.Equal(1, result);
        }

        [Fact]
        public void ErrorTest()
        {
            var result = 2;
            Assert.Equal(2, result);
        }
    }
}
