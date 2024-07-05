using MyLib;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void CanAdd()
    {
        Assert.True(Functions.Add(10, 20) == 30);
    }
}