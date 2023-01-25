using System;
namespace SnakeAndLadder
{
	public class SnakeLadderStartPosition
	{
		public static void startPosition()
		{
			int startPosition = 0;
			Console.WriteLine("Start Position of player:-{0} ",startPosition);
		
		}
		public static void RollDice()
		{
            Random random = new Random();
            int RollDice = random.Next(0, 7);
            Console.WriteLine("After rolling dice getting number is {0}", RollDice);
        }
	}
}

