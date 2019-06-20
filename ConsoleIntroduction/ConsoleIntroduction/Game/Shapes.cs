using ConsoleIntroduction.Game;
using SFML.Graphics;


namespace ConsoleIntroduction
{
     class Shapes
    {   
        public const string CONSOLE_FONT_PATH = "./fonts/arial.ttf";
        public Positions positions;

        Sprite spriteFromFile;
        Font consoleFont;

        public  void LoadContent()
        {
            consoleFont = new Font(CONSOLE_FONT_PATH);
            positions = new Positions();
            Texture texture;

            texture = new Texture("./Images/image1.png");
            spriteFromFile = new Sprite(texture);

        }

        public  void Draw(GameLoop gameLoop)
        {
            uint fontSize = 14;
            if (consoleFont != null)
            {
                string strTotalTimeElapsed = gameLoop.GameTime.TotalTimeElapsed.ToString("0.0000");
                string strDeltaTime = gameLoop.GameTime.DeltaTime.ToString("0.00000");
                float fps = 1 / gameLoop.GameTime.DeltaTime;
                string strFps = fps.ToString();

                Utils.DrawText(gameLoop, strTotalTimeElapsed, consoleFont, Color.White,
                    fontSize, 4, 8);
                Utils.DrawText(gameLoop, strFps, consoleFont, Color.White,
                    fontSize, positions.Fps.X, positions.Fps.Y);
            }

            Utils.DrawText(gameLoop, "press arrows to move text", consoleFont,
                Color.Red, fontSize, 100, 4);
            Utils.DrawText(gameLoop, "click mouse to move circle and change shape direction", consoleFont,
                Color.Red, fontSize, 100, 24);

            Utils.DrawCircle(gameLoop, positions.CircleRadius, Color.Red,
                positions.CircleCenter.X, positions.CircleCenter.Y);

            Utils.DrawTexture(gameLoop, spriteFromFile, 
                positions.Sprite.X, positions.Sprite.Y + positions.OffsetY);
        }

        public void Update()
        {
            if (positions.Up)
            {
                positions.OffsetY--;
            }
            else
            {
                positions.OffsetY++;
            }
        }
    }
}

