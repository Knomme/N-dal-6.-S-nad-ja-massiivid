using System;

namespace StringsAndArrays
{
	class Program
	{
		static void Main(string[] args)
		{

			// Programm küsib kasutaja käest eesnime;
			// Programm kuvab kastuaja eesnime pikkust;


			Console.WriteLine("Sisesta eesnimi:");
			string firstName = Console.ReadLine();

			// int firstNameLength = firstName.Length;

			Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");





		}
	}
}
