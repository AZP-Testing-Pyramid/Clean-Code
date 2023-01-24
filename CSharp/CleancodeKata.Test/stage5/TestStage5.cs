using CleancodeKata.stage5;
using Xunit;

namespace SpeedrunKata.Tests.stage5
{
    public class TestStage5
    {
        private readonly Stage5 stage5 = new Stage5();

        [Fact]
        public void LongWordsAreEligibleIfTheyHave_4Vowels()
        {
            Assert.True(stage5.IsEligible("azertyuiopqsdfg"));
        }

        [Fact]
        public void LongWordsAreEligibleIfTheyHaveAtLeast_3SpecialLetters()
        {
            Assert.True(stage5.IsEligible("rzmztypopqsdfg"));
        }

        [Fact]
        public void ShortWordsAreEligibleIfTheyHaveAtLeast_5LettersInUpperCase()
        {
            Assert.True(stage5.IsEligible("PlKZMZ"));
        }

        [Fact]
        public void ShortWordsAreEligibleIfTheyHave_3Vowels()
        {
            Assert.True(stage5.IsEligible("aeio"));
        }

        [Theory]
        [InlineData("pazof")]
        [InlineData("AOJGKFLDLFMG")]
        [InlineData("")]
        [InlineData("oplm")]
        [InlineData("lkoirp")]
        public void OtherWordsAreNotElligible(string word)
        {
            Assert.False(stage5.IsEligible(word));
        }
    }
}