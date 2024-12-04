namespace Pong_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new Paddle(8);
            Computer = new ComputerPaddle(2, 50, new int[] {5, 6, 8, 9});
            Ball = new Ball(4, 4, new int[] {10, 9, 8, 11, 12});
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.CurrentSpeed = 8;
            Player.HorizontalPosition = 12;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(12, 138);
            Player.Name = "Player";
            Player.Size = new Size(30, 120);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            Player.VerticalPosition = 138;
            // 
            // Computer
            // 
            Computer.CurrentSpeed = 2;
            Computer.HorizontalPosition = 758;
            Computer.Image = (Image)resources.GetObject("Computer.Image");
            Computer.Location = new Point(758, 138);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.SizeMode = PictureBoxSizeMode.StretchImage;
            Computer.SpeedChangeCounter = 50;
            Computer.SpeedChangeFrequency = 50;
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            Computer.VerticalPosition = 138;
            // 
            // Ball
            // 
            Ball.CurrentSpeedX = 4;
            Ball.CurrentSpeedY = 4;
            Ball.HorizontalPosition = 373;
            Ball.Image = (Image)resources.GetObject("Ball.Image");
            Ball.Location = new Point(373, 167);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            Ball.VerticalPosition = 167;
            
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Ball);
            Controls.Add(Computer);
            Controls.Add(Player);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Player: 0 -- Computer: 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Paddle Player;
        private ComputerPaddle Computer;
        private Ball Ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}
