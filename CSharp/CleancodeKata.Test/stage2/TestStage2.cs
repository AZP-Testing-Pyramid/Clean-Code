using CleancodeKata.stage2;
using Xunit;

namespace CleancodeKata.Test.stage2
{
    public class TestStage2
    {
        [Fact]
        public void Score_is_zero_if_all_the_dice_have_the_same_value()
        {
            Assert.Equal(0, Stage2.ComputeScore(1, 1, 1));
            Assert.Equal(0, Stage2.ComputeScore(2, 2, 2));
            Assert.Equal(0, Stage2.ComputeScore(3, 3, 3));
            Assert.Equal(0, Stage2.ComputeScore(4, 4, 4));
            Assert.Equal(0, Stage2.ComputeScore(5, 5, 5));
            Assert.Equal(0, Stage2.ComputeScore(6, 6, 6));
        }

        [Fact]
        public void Score_is_the_sum_of_dice_multiplied_by_2_if_2_dices_have_the_same_value()
        {
            Assert.Equal(10, Stage2.ComputeScore(1, 1, 3));
            Assert.Equal(20, Stage2.ComputeScore(4, 3, 3));
            Assert.Equal(24, Stage2.ComputeScore(2, 5, 5));
            Assert.Equal(12, Stage2.ComputeScore(1, 4, 1));
        }

        [Fact]
        public void Score_is_100_if_dice_are_1_2_3()
        {
            Assert.Equal(100, Stage2.ComputeScore(1, 2, 3));
            Assert.Equal(100, Stage2.ComputeScore(1, 3, 2));
            Assert.Equal(100, Stage2.ComputeScore(2, 1, 3));
            Assert.Equal(100, Stage2.ComputeScore(2, 3, 1));
            Assert.Equal(100, Stage2.ComputeScore(3, 1, 2));
            Assert.Equal(100, Stage2.ComputeScore(3, 2, 1));
        }

        [Fact]
        public void Score_is_the_sum_of_dice_if_no_specific_rules_apply()
        {
            Assert.Equal(8, Stage2.ComputeScore(1, 3, 4));
            Assert.Equal(10, Stage2.ComputeScore(2, 5, 3));
            Assert.Equal(12, Stage2.ComputeScore(4, 6, 2));
        }
    }
}