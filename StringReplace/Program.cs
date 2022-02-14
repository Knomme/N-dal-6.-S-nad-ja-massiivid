using System;

namespace StringReplace
{
	class Program
	{
		static void Main(string[] args)
		{
			// programm asendab kõik 'o' tähed lasues "Hello World!" tärniga (*)

			string helloW = "Hello World!";
			/*
			for (int i = 0; i < helloW.Length; i++)
			{
				helloW[i] = '*'; // Sõnad on muutumatud. 
			}*/

			helloW = helloW.Replace('o', '*');
			helloW = helloW.Replace('!', '1');
			Console.WriteLine(helloW);

		}



	}
}
