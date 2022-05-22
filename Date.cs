using System;

public class Class1
{
	public Class1()
	{

     private int _Month = 7;
    public int Month
    {
        get => _Month;
        set
        {
            if ((value > 0) && (value < 13))
            {
                _Month = value;
                Console.WriteLine(value);
            }
        }

    }
}
}
