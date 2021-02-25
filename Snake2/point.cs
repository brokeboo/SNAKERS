using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
	class point
	{
		public int x;
		public int y;
		public char sym;

		public point()
		{
		}

		public point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public point(point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)
		{
			if (direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(point p)
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}



