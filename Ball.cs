using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Game
{
    internal class Ball : Obstacle
    {
        public int CurrentSpeedX { get; set; }
        public int CurrentSpeedY { get; set; }

        public Ball(int currentSpeedX, int currentSpeedY, int[] speedValues)
        {
            CurrentSpeedX = currentSpeedX;
            CurrentSpeedY = currentSpeedY;
            SpeedValues = speedValues;
        }
        internal void ChangePosition()
        {
            HorizontalPosition -= CurrentSpeedX;
            VerticalPosition -= CurrentSpeedY;
        }

        internal void ChangeSpeed()
        {
            Random random = new Random();
            int x = SpeedValues[random.Next(SpeedValues.Length)];
            int y = SpeedValues[random.Next(SpeedValues.Length)];

            if (CurrentSpeedX < 0)
            {
                CurrentSpeedX = x;
            }
            else
            {
                CurrentSpeedX = -x;
            }

            if (CurrentSpeedY < 0)
            {
                CurrentSpeedY = -y;
            }
            else
            {
                CurrentSpeedY = y;
            }
        }

        internal void CheckHorizontal(int height )
        {
            if (Top < 0 || Bottom > height)
            {
                CurrentSpeedY = -CurrentSpeedY;

            }
        }

        internal bool isAtLeft()
        {
            if(Left < -2)
                return true;

            return false;
        }
        
        internal bool isAtRight(int width)
        {
            if (Right > width + 2)
                return true;

            return false;
        }

        internal void Reset()
        {
            Left = 300;
            CurrentSpeedX = -CurrentSpeedX;
        }
    }
}
