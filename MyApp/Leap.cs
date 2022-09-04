public class Leap 
{
    private int year;
    public bool isLeap;
    public Leap(int year)
    {
        this.year=year;
    }
<<<<<<< HEAD
    public Leap(float year)
    {
        this.year=(int)year;
    }
    public Leap(double year)
    {
        this.year=(int)year;
    }
    public Leap(String year)
    {
        this.year = Convert.ToInt32(year);
    }
    public bool isLeapYear()
    {
        
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0) && year>=1582)
=======
    public bool isLeapYear()
    {
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0) && year!=0)
>>>>>>> e60d2e55cc2ae09d95f3e420a3eb47f4a9078812
        { 
            setLeap();
            return true;
        } else return false; 
    }
<<<<<<< HEAD
    public bool isLeapYear(int year)
    {
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0) && year>=1582)
=======

    public bool isLeapYear(int year)
    {
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0) && year!=0)
>>>>>>> e60d2e55cc2ae09d95f3e420a3eb47f4a9078812
        { 
            setLeap();
            return true;
        } else return false; 
    }
    private void setLeap()
    {
        isLeap=true;
    }
    public bool userInputCheck()
    {

        Console.Write("Enter year for Leapyear check!: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(isLeapYear(number))
        {
            Console.Write("yay");
            return true;
        } else 
        {
            Console.WriteLine("nay");
            return false;
        }
<<<<<<< HEAD
    }
    
=======
    }    
>>>>>>> e60d2e55cc2ae09d95f3e420a3eb47f4a9078812
}