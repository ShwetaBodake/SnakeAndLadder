using System;
namespace SnakeAndLadder
{
	 public class SnakeLadderStartPosition
    {
        Random r = new Random();
        int startPosition = 0;
        int endPosition = 100;
        int diceCount = 0;
       
        public void yourOption()
        {
            while (startPosition <= endPosition)
            {
                diceCount++;
                switch (r.Next(0, 3))
                {
                    case 0:
                        Console.WriteLine("Ladder");
                        int ladderDice = r.Next(1, 7);
                        if (startPosition + ladderDice == 100)
                        {
                            Console.WriteLine("Win" + startPosition);
                            break;
                        }
                        else if (startPosition + ladderDice < 100)
                        {
                            startPosition = startPosition + ladderDice;
                            Console.WriteLine(startPosition);
                        }
                        else
                        {
                            Console.WriteLine("Can not go beyoud 100");
                        }
                        break;
                    case 1:
                        int dice = r.Next(1, 7);
                        Console.WriteLine("Snake");
                        if (startPosition <= dice)
                        {
                            startPosition = 0;
                        }
                        else
                        {
                            startPosition = startPosition - dice;
                            Console.WriteLine(startPosition);
                        }
                        break;
                    case 2:
                        Console.WriteLine("No Play");
                        break;
                    default:
                        Console.WriteLine("In default");
                        break;
                }
            }
            Console.WriteLine("Out of loop" + startPosition);
            Console.WriteLine("Out of loop" + diceCount);
        }

	}
}

