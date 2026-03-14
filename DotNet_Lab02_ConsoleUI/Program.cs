using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Lab02_ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var num = 2026;
			var decimalNum = 3.14m;
			var isTrue = true;
			var boxedNum = (object)num;

			List<object> objects = new List<object>
			{
				num,
				boxedNum,
				decimalNum,
				isTrue
			};

			Console.WriteLine(objects.Count);
			foreach (var obj in objects)
			{
				Console.WriteLine(obj);
			}

			var numbers = new List<int> { 9, 24, 3, 47, 15, 1, 5, 99, 83, 33 };

			// Predicate (reusable logic)
			Func<int, bool> isOdd = n => n % 2 != 0; // bool isOdd(int n) => n % 2 != 0;

			// ------------------------------------
			// LINQ Query Syntax
			// ------------------------------------
			var oddsQuery =
				from n in numbers
				where isOdd(n)
				orderby n descending
				select $"num: {n}";

			// ------------------------------------
			// LINQ Lambda (Method) Syntax
			// ------------------------------------
			var oddsLambda = numbers
				.Where(isOdd)
				.OrderByDescending(n => n)
				.Select(n => $"num: {n}");

			Console.WriteLine("Odd numbers in descending order via Query:");
			foreach (var n in oddsQuery)
			{
				Console.WriteLine(n);
			}

			Console.WriteLine("Odd numbers in descending order via Lambda:");
			foreach (var n in oddsLambda)
			{
				Console.WriteLine(n);
			}
		}
	}
}
