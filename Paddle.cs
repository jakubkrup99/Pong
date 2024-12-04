using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Game
{
    internal class Paddle : Obstacle
    {
        public int CurrentSpeed { get; set; }

        public Paddle(int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
        }

        internal void MoveUp()
        {
            if (Top > 0)
                Top -= CurrentSpeed;
        }

        internal void MoveDown(int height)
        {
            if (Top + Height < height)
            {
                Top += CurrentSpeed;
            }
        }



    }

    
}
