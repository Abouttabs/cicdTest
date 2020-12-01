using System;
using Xunit;

namespace ScratchTest
{
    public class IsItACatTest
    {
        [Theory]
        [InlineData("woof")]
        [InlineData("squeak")]
        [InlineData("neigh")]
        [InlineData("meow")]
        public void DoesItMeow(string sound)
        {
            Assert.True(sound == "meow", "Why doesn't it meow?");
        }
    }
}
