using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };
    class Setting
    {
        public static int Width
        {
            get; set;
        }

        public static int Height
        {
            get; set;
        }

        public static int Speed
        {
            get; set;
        }

        public static int score
        {
            get; set;
        }
        public static int Points
        {
            get; set;
        }

        public static bool GameOver
        {
            get; set;
        }

        public static Directions direction
        {
            get; set;
        }
        public static int Score { get; internal set; }

        public Setting()
        {
            Width = 16;
            Height = 16;
            Speed = 20;
            score = 0;
            Points = 100;
            GameOver= false;
            direction = Directions.Down;
        }
    }
}
