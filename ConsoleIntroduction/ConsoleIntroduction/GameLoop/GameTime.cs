namespace ConsoleIntroduction
{
    public class GameTime
    {
        public void Update(float deltaTime , float totalTimeElapsed)
        {
            DeltaTime = deltaTime;
            TotalTimeElapsed = totalTimeElapsed;
        }

        public float TotalTimeElapsed { get; private set; }

        public float DeltaTimeUnscaled { get; private set; } 

        public float TimeScale { get; set; }
        public float DeltaTime {
            get
            {
                return DeltaTimeUnscaled * TimeScale;
            }
            set
            {
                DeltaTimeUnscaled = value;
            }
        }

        public GameTime()
        {
            TimeScale = 1;
            DeltaTimeUnscaled = 0;
        }
    }
}