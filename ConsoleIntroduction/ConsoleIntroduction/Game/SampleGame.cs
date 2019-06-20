using SFML.Graphics;
using SFML.Window;

namespace ConsoleIntroduction
{
    class SampleGame : GameLoop
    {
        public const uint DEFAULT_WINDOW_WIDTH = 480;
        public const uint DEFAULT_WINDOW_HEIGHT = 640;
        Shapes shapes;

        public SampleGame() : base(DEFAULT_WINDOW_WIDTH, DEFAULT_WINDOW_HEIGHT, 
            "Sample SFML Game",Color.Black)
        {
            shapes = new Shapes();
        }

        public override void Draw(GameTime gameTime)
        {
            /* --- this does not look optimal because the shape is created 
             * --- on every render but the frequency is still almost 60hz */
            shapes.Draw(this);
        }

        public override void Initialize()
        {
            Window.KeyPressed += Window_KeyPressed;
            Window.MouseButtonPressed += Window_MouseButtonPressed;
        }

        private void Window_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            shapes.positions.CircleCenter.X = e.X - shapes.positions.CircleRadius;
            shapes.positions.CircleCenter.Y = e.Y - shapes.positions.CircleRadius;
            shapes.positions.Up = !shapes.positions.Up;
        }

        private void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.Up:
                    if(shapes.positions.Fps.Y > 0)
                    {
                        shapes.positions.Fps.Y--;
                    }
                    break;

                case Keyboard.Key.Down:
                    if (shapes.positions.Fps.Y < DEFAULT_WINDOW_HEIGHT)
                    {
                        shapes.positions.Fps.Y++;
                    }
                    break;

                case Keyboard.Key.Left:
                    if (shapes.positions.Fps.X > 0)
                    {
                        shapes.positions.Fps.X--;
                    }
                    break;

                case Keyboard.Key.Right:
                    if (shapes.positions.Fps.X < DEFAULT_WINDOW_WIDTH)
                    {
                        shapes.positions.Fps.X++;
                    }
                    break;
            }
        }

        public override void LoadContent()
        {
            shapes.LoadContent();
        }


        public override void Update(GameTime gameTime)
        {
            shapes.Update();
        }
    }
}
