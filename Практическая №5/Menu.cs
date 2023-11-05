﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__5
{
    public class Menu
    {
        public static int Show(int minStrelochka, int maxStrelochka)
        {
            int pos = 3;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minStrelochka)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxStrelochka)
                {
                    pos++;
                }
            } while (key.Key != ConsoleKey.Enter);

            return pos;
        }
    }
}
