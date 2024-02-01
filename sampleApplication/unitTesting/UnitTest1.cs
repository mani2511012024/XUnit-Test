using Xunit;


namespace unitTesting;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Programsample sample = new Programsample();


        sample.MobileNumber = 9091929394;
        sample.Email = "karthi123@gmail.com";

        Assert.Equal(9091929394, sample.MobileNumber);
        Assert.Equal("karthi123@gmail.com", sample.Email);
    }

    [Theory]
    [InlineData(9091929394, "karthi123@gmail.com")]
    public void Test2(double mobilenumber, string email)
    {
        Programsample sample = new Programsample();


        sample.MobileNumber = mobilenumber;
        sample.Email = email;

        Assert.Equal(mobilenumber, sample.MobileNumber);
        Assert.Equal(email, sample.Email);
    }
}

public class Programsample
{
    public string Email { get; set; }
    public double MobileNumber { get; set; }
}