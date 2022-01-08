using System;

namespace TimeConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(timeConversion("07:05:45AM"));
		}

		public static string timeConversion(string s)
		{
			if (s[s.Length - 2] == 'A')
			{
				if ((s.Substring(0, 2)).Equals("12"))
					return ("00" + s.Substring(2, 6));

			}
			else
			{
				if (!(s.Substring(0, 2)).Equals("12"))
					return (int.Parse(s.Substring(0, 2)) + 12 + s.Substring(2, 6));

			}
			return (s.Substring(0, 8));
		}
	}
}
