namespace MyApp.Tests;

public class isLeapTest
{
    [Fact]
    public void testing_is_leap()
    {
        // Arrange
        var test1 = new Leap(1);
        var test2 = new Leap(0);
        var test3 = new Leap(4);
        var test4 = new Leap(2000);

         // Act
       test1.isLeapYear();
       test2.isLeapYear();
       test3.isLeapYear();
       test4.isLeapYear();


        // Assert
        test1.isLeap.Should().Be(false);
        test2.isLeap.Should().Be(false);
        test3.isLeap.Should().Be(true);
        test4.isLeap.Should().Be(true);
    }
}