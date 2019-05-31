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

                Text textElapsed = new Text(strTotalTimeElapsed, consoleFont,14);
                textElapsed.Position = new Vector2f(4, 8);
                textElapsed.FillColor = fontColor;

                gameLoop.Window.Draw(textElapsed);

                Text textFps = new Text(strFps, consoleFont, 14);
                textFps.Position = new Vector2f(4, 28);
                textFps.FillColor = fontColor;

                gameLoop.Window.Draw(textFps);
            }
        }

    }
}
