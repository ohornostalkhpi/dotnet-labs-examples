using System;
using System.Collections.Generic;
using DotNet_Lab01_Core;

namespace DotNet_Lab03_ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create storage and add cars
			var storage = new CarStorage
			{
				new Car("Tesla", "Electric car", 2022, "Red") { Speed = 250, IsElectric = true },
				new Car("BMW", "Luxury car", 2018, "Black") { Speed = 220, IsElectric = false },
				new Car("Nissan", "Eco car", 2020, "White") { Speed = 180, IsElectric = true }
			};

			// Iterate using foreach (duck typing)
			// If CarStorage inherited IEnumerable<Car>, it would be required for foreach. Here, only GetEnumerator is needed (duck typing).
			Console.WriteLine("All cars in storage:");
			foreach (var car in storage)
				Console.WriteLine(car);

			// 4. Extension methods
			int number = 42;
			Console.WriteLine($"\nIs {number} even? {number.IsEven()}");
			Console.WriteLine($"\nElectric car count (extension): {storage.CountElectricCars()}");

			// Fast dictionary lookup
			var found = storage.FindByName("Tesla");
			Console.WriteLine($"\nFast lookup by name 'Tesla':\n{found}");

			// LINQ query on dictionary
			var electrics = storage.WhereElectric();
			Console.WriteLine("\nElectric cars:");
			foreach (var car in electrics)
				Console.WriteLine(car.Name);

			// HashSet demo
			var tags1 = new HashSet<string> { "eco", "fast", "luxury", "eco" };
			var tags2 = new HashSet<string> { "fast", "family", "electric" };
			Console.WriteLine("\nTags1 (unique): " + string.Join(", ", tags1));
			Console.WriteLine("Tags2 (unique): " + string.Join(", ", tags2));
			var union = new HashSet<string>(tags1);
			union.UnionWith(tags2);
			Console.WriteLine("Union: " + string.Join(", ", union));
			var intersect = new HashSet<string>(tags1);
			intersect.IntersectWith(tags2);
			Console.WriteLine("Intersection: " + string.Join(", ", intersect));
		}
	}
}
