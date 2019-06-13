using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntroduction
{
    class Utils
    {
        public static void DrawCircle(GameLoop gameLoop,float radius , Color fillColor,
            float x , float y)
        {
            CircleShape circle = new CircleShape(radius);
            circle.FillColor = fillColor;
            circle.Position = new Vector2f(x, y);
            gameLoop.Window.Draw(circle);
        }

        public static void DrawText(GameLoop gameLoop,string text,
            Font font , Color fontColor, uint fontSize,int x , int y)
        {
            Text textFps = new Text(text, font, fontSize);
            textFps.Position = new Vector2f(x, y);
            textFps.FillColor = fontColor;

            gameLoop.Window.Draw(textFps);
        }

        public static void DrawTexture(GameLoop gameLoop ,
            Sprite sprite , int x, int y)
        {
            sprite.Position = new Vector2f(x, y);
            gameLoop.Window.Draw(sprite);
        }
    }
}
