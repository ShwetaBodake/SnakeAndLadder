using System;
namespace SnakeAndLadder
{
	 public class SnakeLadderStartPosition
    {
        int startPosition = 0;
        public int rollDice()
        {
            Random r = new Random();
            return r.Next(0, 7);
        }
	}
}

