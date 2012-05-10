using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib
{
    class InvalidMoveException : Exception
    {
        public InvalidMoveException(string msg) : base(msg) { }
    }
}
