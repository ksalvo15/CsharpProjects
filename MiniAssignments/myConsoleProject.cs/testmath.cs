using System;

public class Class1
{
	public Class1()
	{
		
		
		Console.WriteLine("input a number");
		string usernumber = Console.ReadLine();
		int usernumbers = Convert.ToInt32(usernumber); //this converts the string to int
		Console.WriteLine(usernumbers * 50);
		
		
	}
}
