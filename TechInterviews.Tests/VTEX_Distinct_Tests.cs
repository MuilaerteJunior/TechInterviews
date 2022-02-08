using Xunit;

namespace TechInterviews.Tests;

public class VTEX_Distinct_Tests
{
    /// <summary>
    /// VTEX: From two strings, how to identify if there is any character that exists in both strings
    /// 
    /// 'ABC', 'ZKBD' => TRUE
    /// 'DDD', 'AAAD' => TRUE
    /// 'abc', 'zok' => FALSE
    /// 'AAA', 'BBB' => FALSE
    /// </summary>

    [Theory]
    [InlineData("abc", "zkbd")]
    [InlineData("ddd", "aaaad")]
    public void VTEX_Valid_Results(string firstString, string secondString)
    {
        var companyTest = new VTexApproaches();
        var result = companyTest.ApplyDistinctWithHashsetApproach(firstString, secondString);
        Assert.True(result);
    }

    [Theory]
    [InlineData("abc", "zok")]
    [InlineData("AAA", "bbb")]
    public void VTEX_Invalid_Results(string firstString, string secondString)
    {
        var companyTest = new VTexApproaches();
        var result = companyTest.ApplyDistinctWithHashsetApproach(firstString, secondString);
        Assert.False(result);
    }

    [Theory]
    [InlineData("t")]
    public void VTEX_Valid_Perform_Cases(string firstString)
    {
        var companyTest = new VTexApproaches();
        var secondString = new string('S', 500000 * 999);
        secondString += firstString;
        var result = companyTest.ApplyDistinctWithHashsetApproach(firstString, secondString);
        Assert.True(result);
    }
}