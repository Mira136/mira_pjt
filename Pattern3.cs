using System;

namespace mira_pjt
{
	class Pattern3
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i <= 9; i++)
			{
                int k = i <= 5 ? i : 10 - i;

                for (int j = 1; j <= k; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
