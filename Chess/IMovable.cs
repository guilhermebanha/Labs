using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public interface IMovable
    {
        void Move(int dx, int dy);
    }
}
