using System;

namespace HOLCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lasues Hello World!"


			string helloW = "Hello World!".ToLower();

			int stringLength = helloW.Length;


			int hCounter = 0;

			int oCounter = 0;

			int lCounter = 0;


			for (int i = 0; i < helloW.Length; i++)
			{
				if (helloW[i] == 'h')
				{
					hCounter++;
				}

				else if (helloW[i] == 'o')
				{
					oCounter++;
				}

				else if (helloW[i] == 'l')
				{
					lCounter++;
				}		
			}

			if (hCounter != 1)
			{
				Console.WriteLine($"Hello World'is on {hCounter} 'h' tähte.");
			}
			else
			{
				Console.WriteLine($"Hello World'is on {hCounter} 'h' täht.");
			}

			if (oCounter != 1)
			{

				Console.WriteLine($"Hello World'is on {oCounter} 'o' tähte.");
			}
			else
			{
				Console.WriteLine($"Hello World'is on {oCounter} 'o' täht.");
			}

			if (lCounter != 1)
			{
				Console.WriteLine($"Hello World'is on {lCounter} 'l' tähte.");
			}
			else
			{
				Console.WriteLine($"Hello World'is on {lCounter} 'l' täht.");
			}










		}
	}
}
