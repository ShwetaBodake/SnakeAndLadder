using System;
namespace SnakeAndLadder
{
	 public class SnakeLadderStartPosition
    {
        Random r = new Random();
        int startPosition = 0;
        int endPosition = 100;
       
        public void yourOption()
        {
            while (startPosition <= endPosition)
            {

                switch (r.Next(0, 3))
                {
                    case 1:
                        Console.WriteLine("Ladder");
                        startPosition = startPosition + r.Next(0, 7);
                        break;
                    case 2:
                        int dice = r.Next(0, 7);
                        Console.WriteLine("Snake");
                        if (startPosition <= dice)
                        {
                            startPosition = 0;
                        }
                        else
                        {
                            startPosition = startPosition - dice;
                        }
                        break;
                    case 3:
                        Console.WriteLine("No Play");
                        break;
                    default:
                        Console.WriteLine("In default");
                        break;
                }
                Console.WriteLine(startPosition);
            }
            Console.WriteLine("Out of loop" + startPosition);
        }

	}
}

