using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class program
    {
        static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			point p = new point(4, 5, '*');
			snak snake = new snak(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			WriteGameOver();
			Console.ReadLine();
		}


		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("///////////////////////////", xOffset, yOffset++);
			WriteText("     GAME  OVER", xOffset + 1, yOffset++);
			yOffset++;
			WriteText("///////////////////////////", xOffset, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}

        
    

