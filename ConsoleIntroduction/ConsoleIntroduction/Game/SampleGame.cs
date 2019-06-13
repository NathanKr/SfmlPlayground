using SFML.Graphics;
using SFML.Window;

namespace ConsoleIntroduction
{
    class SampleGame : GameLoop
    {
        public const uint DEFAULT_WINDOW_WIDTH = 640;
        public const uint DEFAULT_WINDOW_HEIGHT = 480;

        public SampleGame() : base(DEFAULT_WINDOW_WIDTH, DEFAULT_WINDOW_HEIGHT, 
            "Sample SFML Game",Color.Black)
        {

        }

        public override void Draw(GameTime gameTime)
        {
            /* --- this does not look optimal because the shape is created 
             * --- on every render but the frequency is still almost 60hz */
            DebugUtility.Draw(this);
        }

        public override void Initialize()
        {
            Window.KeyPressed += Window_KeyPressed;
            Window.MouseButtonPressed += Window_MouseButtonPressed;
        }

        private void Window_MouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            DebugUtility.circleX = e.X;
            DebugUtility.circleY = e.Y;
        }

        private void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e)
        {
            switch (e.Code)
            {
                case Keyboard.Key.Up:
                    if(DebugUtility.fpsY > 0)
                    {
                        DebugUtility.fpsY--;
                    }
                    break;

                case Keyboard.Key.Down:
                    if (DebugUtility.fpsY < DEFAULT_WINDOW_HEIGHT)
                    {
                        DebugUtility.fpsY++;
                    }
                    break;

                case Keyboard.Key.Left:
                    if (DebugUtility.fpsX > 0)
                    {
                        DebugUtility.fpsX--;
                    }
                    break;

                case Keyboard.Key.Right:
                    if (DebugUtility.fpsX < DEFAULT_WINDOW_WIDTH)
                    {
                        DebugUtility.fpsX++;
                    }
                    break;
            }
        }

        public override void LoadContent()
        {
            DebugUtility.LoadContent();
        }



        public override void Update(GameTime gameTime)
        {
           // DebugUtility.sprite.tra
        }
    }
}
