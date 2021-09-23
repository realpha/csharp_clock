using Xunit;

public class ClockTests
{
    [Fact]
    public void On_the_hour()
    {
        var sut = new Clock(8, 0);
        Assert.Equal("08:00", sut.ToString());
    }

    [Fact]
    public void Past_the_hour()
    {
        var sut = new Clock(11, 9);
        Assert.Equal("11:09", sut.ToString());
    }

    [Fact]
    public void Midnight_is_zero_hours()
    {
        var sut = new Clock(24, 0);
        Assert.Equal("00:00", sut.ToString());
    }

    // Add more tests here.
}
