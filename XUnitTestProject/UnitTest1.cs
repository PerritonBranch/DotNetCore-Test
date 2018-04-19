using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test3()
        {
            Assert.False(false);
        }

        [Fact]
        public void TestPullRequest()
        {
            Assert.Equal(1,1);
        }

        [Fact]
        public void TestPullRequest2()
        {
            Assert.Equal(0, 1);
        }
    }
}
