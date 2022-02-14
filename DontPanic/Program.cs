using System;

namespace DontPanic
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm asendab kõik 'o' tähed lasues "Dont Painic" nulliga '0'
			// Programm asenab kõik 'a' tähed neljaga '4'

			string dontPanic = "Dont Painic";
			/*
			for (int i = 0; i < helloW.Length; i++)
			{
				helloW[i] = '*'; // Sõnad on muutumatud. 
			}*/

			dontPanic = dontPanic.Replace('o', '0');
			dontPanic = dontPanic.Replace('a', '4');
			Console.WriteLine(dontPanic);


		}
	}
}
