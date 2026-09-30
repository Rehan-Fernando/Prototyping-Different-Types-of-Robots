using System;
using System.Collections.Generic;
using System.Text;

namespace _30thOfSep
{
    public interface IRobot
    {
        IRobot Clone();
        void Display();
    }
}
