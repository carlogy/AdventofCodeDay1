using System;
using System.IO;


namespace Day1AOC
{
	public class InputParse
	{
		public static int WhoToAsk()

		{
            
			Console.Write("Enter path of InputFile: ");
			var path = Console.ReadLine();


			var InputFile =  File.ReadAllLines(path); 
		
			List<int> TotalCalories = new List<int>();
			List<int> Elf = new List<int>();
			



            foreach (var line in InputFile)
			{
				if (!string.IsNullOrWhiteSpace(line))
				{
					var calories = Convert.ToInt32(line);
					Elf.Add(calories);
					

				} else if(string.IsNullOrWhiteSpace(line))
				{
					var ElfCalories = Elf.Sum();
					TotalCalories.Add(ElfCalories);
					Elf.Clear();
					
				}
			}

			var ElfToAsk = TotalCalories.Max();

			TotalCalories.Sort();
			TotalCalories.Reverse();

			var ElvesToAsk = TotalCalories.GetRange(0, 3);
		

			int TopThree = ElvesToAsk.Sum();

			
			// First part of Day 1:
			//var Elements = InputFile.Count();
			//Console.WriteLine(Elements);
			
			return TopThree; 
		}
	}
}

