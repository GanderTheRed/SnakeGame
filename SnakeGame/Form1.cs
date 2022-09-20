namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Square> Snake = new List<Square>(); //Creates a list array for the snake.
        private Square food = new Square();  // Creates a square class called food.


        public Form1()
        {
            InitializeComponent();

            new Settings(); // linking the Settings Class to this Form

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += updateScreen; //Linking an update screen function to the timer. Runs each time the interval happens.
            gameTimer.Start(); //Starts the timer.

            startGame(); //Starts the game
                      
        }
        private void updateScreen(object sender, EventArgs e)
        {
            //Timers update function which runs with each tick.

            if (Settings.GameOver == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    //Runs if the game is over and the enter key is pressed.
                    startGame();
                }
            }
            else
            {
                //If the game isn't over the following commands run.
                //Following key inputs change direction as ling as the direction isn't opposite
                if (Input.KeyPress(Keys.Right) && Settings.Direction != Directions.Left)
                {
                    Settings.Direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Settings.Direction != Directions.Right)
                {
                    Settings.Direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.Direction != Directions.Down)
                {
                    Settings.Direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.Direction != Directions.Up)
                {
                    Settings.Direction = Directions.Down;
                }
                movePlayer(); //Runs the move player function
            }
            pbCanvas.Invalidate(); //Refreshes the picture box with new graphics.
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {

        }

        private void startGame()
        {

        }

        private void movePlayer()
        {

        }

        private void generateFood()
        {

        }

        private void eat()
        {

        }

        private void die()
        {

        }
    }
}