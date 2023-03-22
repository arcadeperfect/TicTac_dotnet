﻿using System;

namespace TicTac
{
    public class ConsolePrinter
    {
        private Board Board;
        public ConsolePrinter(Board board)
        {
            Board = board;
        }

        public void Print(string message)
        {
            Console.Clear();
            Console.WriteLine(Board);
            Console.WriteLine(message);
        }
    }
}