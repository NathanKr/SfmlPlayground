using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;



namespace ConsoleIntroduction
{
    abstract class GameLoop
    {

        public abstract void LoadContent();
        public abstract void Initialize();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);

        public void Run()
        {
            LoadContent();
            Initialize();

            float totalTimeBeforeUpdate = 0;
            float previouseTimeElapsed = 0;
            float deltaTime = 0;
            float totalTimeElapsed = 0;

            Clock clock = new Clock();
            while (Window.IsOpen)
            {
                // --- we need to call this so SFML will handle events
                Window.DispatchEvents();

                totalTimeElapsed = clock.ElapsedTime.AsSeconds();
                deltaTime = totalTimeElapsed - previouseTimeElapsed;
                previouseTimeElapsed = totalTimeElapsed;
                totalTimeBeforeUpdate += deltaTime;
                if(totalTimeBeforeUpdate >= TIME_UNTIL_UPDATE)
                {
                    // i think this is correct GameTime.Update(deltaTime, totalTimeElapsed);
                    // thats what he did but first arg is deltatime 
                    GameTime.Update(totalTimeBeforeUpdate, totalTimeElapsed);
                    totalTimeBeforeUpdate = 0;

                    // --- seems that you do here pure logic
                    Update(GameTime);

                    // --- sfml issue -> you must call clear before render
                    Window.Clear(WindowClearColor);

                    Draw(GameTime);

                    // --- sfml will display
                    Window.Display();
                }
            }
        }

        


        // --- protected because this is abstract class -> so why need it ???
        protected GameLoop(
            uint windowWidth , uint windowHeight , 
            string windowTitle , Color windowClearColor)
        {
            this.WindowClearColor = windowClearColor;
            Window = new RenderWindow(new VideoMode(windowWidth , windowHeight),windowTitle);
            GameTime = new GameTime();
            Window.Closed += WindowClosed;
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Window.Close();
        }

        public RenderWindow Window
        {
            get;
            protected set;
        }

        public Color WindowClearColor
        {
            get;
            protected set;
        }

        public GameTime GameTime
        {
            get;
            protected set;
        }

        public const int TARGET_FPS = 60;
        public const float TIME_UNTIL_UPDATE = 1f / TARGET_FPS;
    }
}
