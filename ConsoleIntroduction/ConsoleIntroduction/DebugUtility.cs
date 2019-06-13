using SFML.Graphics;
using SFML.System;

namespace ConsoleIntroduction
{
    static class DebugUtility
    {
        public const string CONSOLE_FONT_PATH = "./fonts/arial.ttf";
        public static int fpsX { get; set; } = 4;
        public static int fpsY { get; set; } = 28;
        public static int circleX { get; set; } = 100;
        public static int circleY { get; set; } = 100;
        public static Sprite sprite { get; set; }

        static Texture texture;
        static Font consoleFont;

        public static void LoadContent()
        {
            consoleFont = new Font(CONSOLE_FONT_PATH);
            texture = new Texture("./Images/image1.png");
        }

        public static void Draw(GameLoop gameLoop)
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
                    fontSize, fpsX, fpsY);
                Utils.DrawText(gameLoop, "press arrows to move text", consoleFont,
                    Color.Red, fontSize, 150, 4);
                Utils.DrawText(gameLoop, "circle move to mouse click", consoleFont,
                    Color.Red, fontSize, 150, 24);

                Utils.DrawCircle(gameLoop,50, Color.Red, circleX, circleY);

                sprite = new Sprite(texture);
                Utils.DrawTexture(gameLoop, sprite,100,300);
            }
        }
    }
}
