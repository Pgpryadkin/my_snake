﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
            /* небольшие измененния 2 */
            /* небольшие измененния 3 */
            /* небольшие измененния 31 */
            Point p1 = new Point(1, 3, '*');
			p1.Draw();

			Point p2 = new Point(4, 5, '#');
			p2.Draw();

			Console.ReadLine();
		}
	}
}
