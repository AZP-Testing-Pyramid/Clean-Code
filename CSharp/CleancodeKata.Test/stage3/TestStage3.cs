using CleancodeKata.stage3;
using Xunit;

namespace CleancodeKata.Test.stage3
{
    public class TestStage3
    {
        [Theory]
        [InlineData("aeiou", "short_odd_aeiou")]
        [InlineData("AEIOUY", "short_even_aeiouy")]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "long_even_aBCDeFGHiJKLMNoPQRSTuVWXyZ")]
        [InlineData("kjqtrpmnz", "short_odd_kjqtrpmnz")]
        [InlineData("kjqtrpmnzr", "long_even_kjqtrpmnzr")]
        [InlineData("kjqtrApmnzsr", "long_even_kjqtrapmnzsr")]
        public void DoTheThing_transforms_the_input_string(string input, string output)
        {
            Assert.Equal(output, Stage3.DoTheThing(input));
        }

        [Fact]
        public void DoTheThing_transforms_an_empty_string()
        {
            Assert.Equal("short_even_", Stage3.DoTheThing(""));
        }
    }
}