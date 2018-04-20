using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestPullRequest()
        {
            Assert.Equal(1,1);
        }

        [Fact]
        public void TestPullRequest2()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void TestPullRequest3()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void TestPullRequest4()
        {
            Assert.Equal(1, 0);
        }
    }
}
