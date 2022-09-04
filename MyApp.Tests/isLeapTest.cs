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
        var test5 = new Leap(1582);
        var test6 = new Leap(1580);
        var test7 = new Leap(1584);
        var test8 = new Leap(1600.5);
        var test9 = new Leap(1424123.5454054);
        var test10 = new Leap("4000");
        

         // Act
       test1.isLeapYear();
       test2.isLeapYear();
       test3.isLeapYear();
       test4.isLeapYear();
       test5.isLeapYear();
       test6.isLeapYear();
       test7.isLeapYear();
       test8.isLeapYear();
       test9.isLeapYear();
       test10.isLeapYear();


        // Assert
        test1.isLeap.Should().Be(false);
        test2.isLeap.Should().Be(false);
        test3.isLeap.Should().Be(false);
        test4.isLeap.Should().Be(true);
        test5.isLeap.Should().Be(false);
        test6.isLeap.Should().Be(false);
        test7.isLeap.Should().Be(true);
        test8.isLeap.Should().Be(true);
        test9.isLeap.Should().Be(false);
        test10.isLeap.Should().Be(true);
        test3.isLeap.Should().Be(true);
        test4.isLeap.Should().Be(true);
    }
}