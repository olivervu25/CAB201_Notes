class MyClock 
{

    // Fields 
    private int hour;
    private int minute;
    private int second;
    
    // Properties 
    private int Hour
    {
        get { return hour; }
        set 
        {
            // 'value' is a keyword that represents the value being assigned to the property
            if ((value < 0) || (value > 23)}
            {
                Console.WriteLine("Invalid"); 
                // Environment.Exit(-1) will terminate the program. 
                Environment.Exit(-1); 
            })
            hour = value; 
        }
    }
    private int Minute
    {
        get { return minute; }
        set 
        { 
            if ((value < 0) || (value > 59)}
            {
                Console.WriteLine("Invalid"); 
                Environment.Exit(-1); 
            })

            minute = value; 
        }
    }

    private int Second
    {
        get { return second; }
        set 
        { 
            if ((value < 0) || (value > 59)}
            {
                Console.WriteLine("Invalid"); 
                Environment.Exit(-1); 
            })

            second = value; 
        }
    }

    // Constructor
    public MyClock(int hour, int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    // Method 
    public void DisplayTime()
    {
        Console.WriteLine($"{Hour}:{Minute}:{Second}");
    }

}