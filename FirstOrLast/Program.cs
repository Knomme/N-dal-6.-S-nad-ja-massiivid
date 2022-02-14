using System;

namespace FirstOrLast
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm küsib kastuaja ees ja perekonnanime;
			// Programm kontrollib andmete pikkust;
			// Programm kuvab kumb nendest on pikem;


			Console.WriteLine("Sisesta oma eesnimi:");
			string firstName = Console.ReadLine();
			Console.WriteLine("Sisesta oma perekonnanimi:");
			string lastName = Console.ReadLine();

			if (firstName.Length > lastName.Length)
			{
				Console.WriteLine($"Sinu eesmini on pikem. Eesnimes on {firstName.Length} sümbolit.");

			}
			else if (firstName.Length < lastName.Length)
			{
				Console.WriteLine($"Sinu perekonnanimi on pikem. perekonnanimes on {lastName.Length} sümbolit.");
			}
			else
			{
				Console.WriteLine($"Mõlemas nimes on samapalju sümboleid. Eesnimes {firstName.Length} ja perekonnanimes {lastName.Length}");
			}

		}	
	}
}
