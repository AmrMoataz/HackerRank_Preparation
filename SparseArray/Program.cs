using System;
using System.Collections.Generic;

namespace SparseArray
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = matchingStrings(new List<string> { "def", "de", "fgh" }, new List<string> { "de", "lmn", "fgh" });
		}

		public static List<int> matchingStrings (List<string> strings, List<string> queries)
		{
			var array = new List<int>();

			foreach (var query in queries)
			{
				var found = 0;

				foreach (var str in strings)
				{
					if (query.Equals(str))
					{
						found++;
					}
				}

				array.Add(found);
			}

			return array;
		}
	}
}
