using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public bool hasSideCar { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Wear a helmet on your motorcycle!");
        }

        public override void DriveVirtual()
        {
            Console.Write("Motorcycles are fun!  ");
        }
    }
}

