using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong_Game
{
    internal abstract class Obstacle : PictureBox
    {
        public int VerticalPosition { get { return this.Top; } set { this.Top = value; } }
        public int HorizontalPosition { get { return this.Left; } set { this.Left = value; } }


        public int[] SpeedValues;

    }
}
