using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntroduction
{
    static class DebugUtility
    {
        public const string CONSOLE_FONT_PATH = "./fonts/arial.ttf";
        public static Font consoleFont;
        public static void LoadContent()
        {
            consoleFont = new Font(CONSOLE_FONT_PATH);
        }

        public static void DrawPerformanceData(GameLoop gameLoop,Color fontColor)
        {
            if (consoleFont != null)
            {
                string strTotalTimeElapsed = gameLoop.GameTime.TotalTimeElapsed.ToString("0.0000");
                string strDeltaTime = gameLoop.GameTime.DeltaTime.ToString("0.00000");
                float fps = 1 / gameLoop.GameTime.DeltaTime;
                string strFps = fps.ToString();

                Text text = new Text(strTotalTimeElapsed, consoleFont,14);
                text.Position = new Vector2f(4, 8);
                text.FillColor = fontColor;

                gameLoop.Window.Draw(text);
            }
        }

    }
}
