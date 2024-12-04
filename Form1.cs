namespace Pong_Game
{
    public partial class Form1 : Form
    {
        Engine engine = new Engine(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            int height = this.ClientSize.Height;
            int width = this.ClientSize.Width;

            Engine.Run(ref engine, ref Ball, ref Player, ref Computer, height, width);

            Engine.CheckCollision(ref Ball, Player, Player.Right + 5);
            Engine.CheckCollision(ref Ball, Computer, Computer.Left - 35);
            this.Text =  $"Player Score: {engine.PlayerScore} -- Computer Score: {engine.ComputerScore}";
            ;

            if (engine.ComputerScore > 5)
            {
                engine.GameOver("Sorry you lost the game", ref GameTimer, ref Ball, ref Computer);
            }
            else if (engine.PlayerScore > 5)
            {
                engine.GameOver("You won this game", ref GameTimer, ref Ball, ref Computer);
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                engine.GoDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                engine.GoUp = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                engine.GoDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                engine.GoUp = false;
            }

        }
        
    }
}
