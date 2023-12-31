namespace TestStryker.Tests;

public class UnitTest1
{
    private readonly SomeClass _sut = new SomeClass();

    [Fact]
    public void Test1()
    {
        var actual = _sut.Add(1, 2);
        Assert.Equal(3, actual);
    }
}