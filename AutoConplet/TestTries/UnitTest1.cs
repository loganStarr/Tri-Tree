using AutoConplet;
using System;
using Xunit;

namespace TestTries
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);

        }

        [Theory]
        [InlineData(new object[2] { 5, new int[3] { 1, 2, 3 } })]
        [InlineData(new object[2] { 3, new int[3] { 1, 2, 3 } })]
        public void Test2(int a, int[] b)
        {
            Tries t = new Tries();
            t.Add("aye");
            t.Add("ayee");
            t.Add("ayeee");
            if (t.Head.list.Count == 1)
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }

        }
    }
}
