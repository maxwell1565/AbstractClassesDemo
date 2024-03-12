using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

		public int Year { get; set; } = 1;
		public string Make { get; set; } = "Default";
		public string Model { get; set; } = "Default";

		public abstract void DriveAbstract();
		public virtual void DriveVirtual()
		{
			Console.WriteLine("I like to drive safe...");
		}


	}
}

