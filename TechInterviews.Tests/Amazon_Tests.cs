using System.Linq;
using Xunit;

namespace TechInterviews.Tests;
public class Amazon_Tests {

    /// <summary>
    /// From a sequence of numbers representing stock value, identify which day buying and
    /// which day selling you will have the higher profit.
    /// 
    /// d0 d1 d2 d3 d4 d5 d6 d7 d8  d9
    /// 4  5  6  7  2  4  5  6  19   3 => d5, d9
    /// 1  5  2  3  4  1  9  7  9    1 => d0, d6
    /// 9  8  6  5  4  3  2  1       => No profit [7, 7] 
    /// </summary>
    [Theory]
    [InlineData(new int[] { 4, 5, 6, 7, 2, 4, 5, 6, 19 }, 4, 8 )]
    [InlineData(new int[] { 1  ,5  ,2  ,3  ,4  ,1  ,9  ,7  ,9 }, 0, 6 )]
    [InlineData(new int[] { 9, 8, 6 ,5 ,4 ,3 ,2 ,1 }, 7, 7 )]
    public void Amazon(int[] stockValueDay, int expectedDayBuy, int expectedDaySell)
    {
        var amazon = new AmazonApproaches();
        var myDayIndexes = amazon.IdentifyDays(stockValueDay);
        Assert.Equal(expectedDayBuy, myDayIndexes[0]);
        Assert.Equal(expectedDaySell, myDayIndexes[1]);
    }
}
