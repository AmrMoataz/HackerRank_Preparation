using System;
using System.Collections.Generic;

namespace Pangrams
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Pangrams("We promptly judged antique ivory buckles for the prize"));
		}

		private static string Pangrams(string s)
		{
			var result = "";
			var alphapets = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

			foreach (var character in s.ToLower())
			{
				if (alphapets.Contains(character))
				{
					alphapets.Remove(character);
				}
			}

			if (alphapets.Count > 0)
			{
				result = "not pangram";
			}
			else
			{
				result = "pangram";
			}


			return result;
		}
	}
}
