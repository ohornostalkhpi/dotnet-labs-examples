using DotNet_Lab01_Core;
using System;
using System.Collections.Generic;

namespace DotNet_Lab01_UI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = 3; // var count = 3;
			count += 2;
			Console.WriteLine("Count: {0}", count);
			
			var car = new Car();
			Console.WriteLine("Enter the name of the car:");
			car.Name = Console.ReadLine();
			Console.WriteLine("Enter the description of the car:");
			car.Description = Console.ReadLine();
			Console.WriteLine("Enter the manufacturing year of the car:");
			car.ManufactirngYear = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the speed of the car:");
			car.Speed = float.Parse(Console.ReadLine());
			Console.WriteLine("Is the car electric? (true/false):");
			car.IsElectric = bool.Parse(Console.ReadLine());
			Console.WriteLine("Enter the color of the car:");
			car.Color = Console.ReadLine();

			Console.WriteLine(car.ToString());
			Console.ReadKey();

			Car car2 = new Car("Kia", "Soul", 2015, "Green");
			var cars = new List<Car>()
			{
				car,
				car2
			};

			foreach (var c in cars)
			{
				Console.WriteLine(c.ToString());
			}
		}
	}
}
