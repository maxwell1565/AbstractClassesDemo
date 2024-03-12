using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

        public bool hasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Cars are fun to drive!");
        } 
    }
}

