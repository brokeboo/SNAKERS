using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
	class FoodCreator
	{
		int mapWidht;
		int mapHeight;
		char sym;

		Random random = new Random();

		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidht = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		public point CreateFood()
		{
			int x = random.Next(2, mapWidht - 2);
			int y = random.Next(2, mapHeight - 2);
			return new point(x, y, sym);
		}
	}
}
