using System;
using System.Collections.Generic;
namespace Assignment_1_Dr
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}
		}
	}

	public static class SubsequenceFinder
	{

		public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
		{
			throw new NotImplementedException();
		}
	}

	class CardPicker
	{
		static Random random = new Random(1);

		public static string[] PickSomeCards(int numCards)
		{
			//
			int k;
			string[] set = new string[1];
			for (k = 0; k < set.Length; k++)
			{

				Console.WriteLine(set[k]);

			}
			RandomValue();
			RandomSuit();
			return set;

		}

		private static string[] RandomValue()
		{
			int randomV;
			String[] RValue = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
			randomV = random.Next(RValue.Length);
			Console.WriteLine(RValue[0]);
			Console.WriteLine(RValue[1]);
			Console.WriteLine(RValue[2]);
			Console.WriteLine(RValue[3]);
			Console.WriteLine(RValue[4]);
			Console.WriteLine(RValue[5]);
			Console.WriteLine(RValue[6]);
			Console.WriteLine(RValue[7]);
			Console.WriteLine(RValue[8]);
			Console.WriteLine(RValue[9]);
			Console.WriteLine(RValue[10]);
			Console.WriteLine(RValue[11]);
			Console.WriteLine(RValue[12]);
			return RValue;
		}

		private static string[] RandomSuit()
		{
			int randomS;
			String[] RSuit = { "Hearts", "Clubs", "Diamonds", "Spades" };
			randomS = random.Next(RSuit.Length);
			Console.WriteLine(RSuit[0]);
			Console.WriteLine(RSuit[1]);
			Console.WriteLine(RSuit[2]);
			Console.WriteLine(RSuit[3]);
			return RSuit;
		}
	}

}


