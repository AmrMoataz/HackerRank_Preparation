using System;

namespace FlippingBits
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(flippingBits(1));
		}

		public static long flippingBits(long n)
		{
			var binary = Convert.ToString(n, 2);
			var binaryString = "";

			for (int i = 0; i < 32 - binary.Length; i++)
			{
				binaryString += 0;
			}

			binaryString += binary;

			var convertedString = "";
			foreach (var c in binaryString)
			{
				if (c == '1')
				{
					convertedString += "0";
				}
				else if (c == '0')
				{
					convertedString += "1";
				}
			}

			var result = Convert.ToInt64(convertedString, 2);
			return result;
		}
	}
}
