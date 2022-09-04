public class Leap 
{
    private int year;
    public bool isLeap;
    public Leap(int year)
    {
        this.year=year;
    }
    public bool isLeapYear()
    {
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0) && year!=0)
        { 
            setLeap();
            return true;
        } else return false; 
    }
    public bool isLeapYear(int year)
    {
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0) && year!=0)
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
    }
    
}