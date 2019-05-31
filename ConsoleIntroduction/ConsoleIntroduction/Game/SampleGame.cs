using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DebugUtility.DrawPerformanceData(this, Color.White);
        }

        public override void Initialize()
        {
           // throw new NotImplementedException();
        }

        public override void LoadContent()
        {
            DebugUtility.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
          //  throw new NotImplementedException();
        }
    }
}
