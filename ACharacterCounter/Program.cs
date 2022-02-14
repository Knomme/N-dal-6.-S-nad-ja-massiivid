using System;

namespace ACharacterCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm palub kastuajal sisestada ees ja perekonnanime;
			// Programm kuvab, mitu "a" tähte kasutaja ees ja perekonna nimes kokku on;


			Console.WriteLine("Sisesta oma eesnimi:");
			string firstName = Console.ReadLine().ToLower();
			Console.WriteLine("Sisesta oma perekonnanimi:");
			string lastName = Console.ReadLine().ToLower();

			int aCounter = 0;

			string fullName = $"{firstName}{lastName}".ToLower();



			for (int i = 0; i < fullName.Length; i++)
			{
				if (fullName[i] == 'a')
				{
					aCounter++;
				}
			}

			if (aCounter != 1)
			{

				Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
			}

			else
			{

				Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
			}
		}
	}
}
