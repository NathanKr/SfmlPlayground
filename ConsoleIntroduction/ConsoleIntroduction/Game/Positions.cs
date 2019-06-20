using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIntroduction.Game
{
    class Positions
    {
        public Positions()
        {
            Fps = new Point { X = 4, Y = 28 };
            CircleCenter = new Point { X = 100, Y = 100 };
            Sprite = new Point { X = 100, Y = 300 };
        }

        
        public Point CircleCenter { get; set; }
        public int CircleRadius { get; set; } = 50;

        public Point Sprite { get; set; }

        public Point Fps { get; set; }
        public bool Up { get; set; }
        public int OffsetY { get; set; }
    }
}
