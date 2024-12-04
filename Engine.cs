using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Game
{
    internal class Engine
    {
        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }


      
       

        public Engine(int playerScore, int computerScore)
        {
            PlayerScore = playerScore;
            ComputerScore = computerScore;
            
        }

        public static void Run(ref Engine engine, ref Ball ball, ref Paddle player, ref ComputerPaddle computer, int height, int width)
        {


            ball.ChangePosition();

            ball.CheckHorizontal(height);

            if (ball.isAtLeft())
            {
                ball.Reset();
                engine.ComputerScore++;

            }

            if (ball.isAtRight(width))
            {
                ball.Reset();
                engine.PlayerScore++;

            }

            computer.CheckHorizontal(height);


            computer.FollowBall(ball);

            computer.SpeedChangeCounter--;

            if (computer.SpeedChangeCounter < 0)
            {
                computer.ChangeSpeed();
            }

            if (engine.GoDown)
            {
                player.MoveDown(height);
            }

            if (engine.GoUp)
            {
                player.MoveUp();
            }



        }

        public static void CheckCollision(ref Ball ball, Paddle player, int offset)
        {
            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                ball.Left = offset; 
                ball.ChangeSpeed();
            }
        }

        internal void GameOver(string message, ref System.Windows.Forms.Timer gameTimer, ref Ball ball, ref ComputerPaddle computer)
        {
            gameTimer.Stop();
            MessageBox.Show(message, "Result: ");
            ComputerScore = 0;
            PlayerScore = 0;
            ball.CurrentSpeedX = ball.CurrentSpeedY = 4;
            computer.SpeedChangeCounter = 50;
            gameTimer.Start();
        }
    }
}
