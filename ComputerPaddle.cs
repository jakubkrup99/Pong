using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Game
{
    internal class ComputerPaddle : Paddle
    {
        public int SpeedChangeFrequency { get; set; }
        public int SpeedChangeCounter { get; set; }

        public ComputerPaddle(int currentSpeed, int speedChangeFrequency, int[] speedValues) : base(currentSpeed)
        {
           SpeedChangeFrequency = speedChangeFrequency;
           SpeedChangeCounter = speedChangeFrequency;
           SpeedValues = speedValues;
        }

        public void ChangeSpeed()
        {
            Random random = new Random();

            CurrentSpeed = SpeedValues[random.Next(SpeedValues.Length)];
            SpeedChangeCounter = 50;
        }

        public void CheckHorizontal(int height)
        {
            if (Top <= 1)
            {
                Top = 0;

            }
            else if (Bottom >= height)
            {
                Top = height - Height;
            }
        }

        public void FollowBall(Ball ball)
        {
            if (ball.Top < Top + (Height / 2) && ball.Left > 300)
            {
                Top -= CurrentSpeed;
            }

            if (ball.Top > Top + (Height / 2) && Left > 300)
            {
                Top += CurrentSpeed;
            }
        }

    }
}
