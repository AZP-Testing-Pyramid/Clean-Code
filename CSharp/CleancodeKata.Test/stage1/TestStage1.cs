using System.Collections.Generic;
using CleancodeKata.stage1;

namespace CleancodeKata.Test.stage1
{
    public class TestStage1
    {
        // [Theory]
        // [MemberData(nameof(ProvideCarts))]
        //public void ComputePrice(Items[] cart, int expectedPrice)
        //{
        //    Stage1 stage1 = new Stage1();
        //    // When
        //    int price = stage1.ComputePrice(cart);
        //    // Then
        //    Assert.AreEqual(expectedPrice, price);
        //}

        public static IEnumerable<object[]> ProvideCarts
        {
            get
            {
                return new[]
                {
                    new object[] {new[] {Stage1.Items.APPLE, Stage1.Items.TOMATO, Stage1.Items.BANANA}, 6},
                    new object[] {new[] {Stage1.Items.POTATO, Stage1.Items.POTATO}, 2},
                    new object[] {new[] {Stage1.Items.LETTUCE, Stage1.Items.TOMATO, Stage1.Items.POTATO}, 5},
                    new object[]
                        {new[] {Stage1.Items.APPLE, Stage1.Items.PEER, Stage1.Items.BANANA, Stage1.Items.PEER}, 8}
                };
            }
        }
    }
}