﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.ConsoleApp
{
    public class GameboardPosition
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public GameboardPosition()
        {
            Row = -1;
            Column = -1;
        }
    }
}
