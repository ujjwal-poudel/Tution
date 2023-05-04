using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeGame
{
    public partial class Form1 : Form
    {
        // creating an list array for the snake
        private List<Circle> Snake = new List<Circle>();

        // creating a single Circle class called food
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();
            // linking the Settings Class to this Form
            new Setting();

            // game time to settings speed
            timer1.Interval = 1000 / Setting.Speed;

            // linking a updateScreen function to the timer
            timer1.Tick += updateSreen;

            // starting the timer
            timer1.Start();

            // running the start game function
            startGame();
        }

        private void updateSreen(object sender, EventArgs e)
        {
            // this is the Timers update screen function. 
            // each tick will run this function
            if (Setting.GameOver == true)
            {
                // if the game over is true and player presses enter
                // we run the start game function
                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                //if the game is not over then the following commands will be executed
                // below the actions will probe the keys being presse by the player
                // and move the accordingly
                if (Input.KeyPress(Keys.Right) && Setting.direction != Directions.Left)
                {
                    Setting.direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Setting.direction != Directions.Right)
                {
                    Setting.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Setting.direction != Directions.Down)
                {
                    Setting.direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Setting.direction != Directions.Up)
                {
                    Setting.direction = Directions.Down;
                }
                movePlayer(); // run move player function
            }
            pbgraphic.Invalidate(); // refresh the picture box and update the graphics on it
        }
        private void movePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //at the initail state
                if (i == 0)
                {
                    switch (Setting.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;

                        case Directions.Left:
                            Snake[i].X--;
                            break;

                        case Directions.Up:
                            Snake[i].Y++;
                            break;


                        case Directions.Down:
                            Snake[i].Y--;
                            break;
                    }

                    int maxXPos = pbgraphic.Size.Width / Setting.Width;
                    int maxYPos = pbgraphic.Size.Height / Setting.Height;

                    //creating border in the game
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X > maxXPos || Snake[i].Y > maxYPos)
                    {
                        end();
                    }

                    //if snake collides in it's body parts
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            end();
                        }
                    }

                    //if snake collides in the food by head
                    if (Snake[0].X == food.X || Snake[0].Y == food.Y)
                    {
                        eat();
                    }
                }

                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            Input.changeStates(e.KeyCode, true);
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            Input.changeStates(e.KeyCode, true);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            //creating new graphic named graphic
            Graphics graphic = e.Graphics;

            if (Setting.GameOver == false)
            {
                Brush color;

                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        //Painting the snake head as yellow
                        color = Brushes.Yellow;
                    }

                    else
                    {
                        //painting body parts as green
                        color = Brushes.Green;
                    }

                    //drawing snake's parts
                    graphic.FillEllipse(color,
                        new Rectangle(Snake[i].X * Setting.Width,
                        Snake[i].Y * Setting.Height, Setting.Width,
                        Setting.Height));

                    //drawing snake's food
                    graphic.FillEllipse(color,
                        new Rectangle(food.X * Setting.Width,
                        food.Y * Setting.Height, Setting.Width,
                        Setting.Height));
                }
            }

            else
            {
                //graphics for game over
                string gameOver = "Your Score is: " + Setting.score + "\n!Game Over" + "\nPress enter to continue again";
                label3.Text = gameOver;
                label3.Visible = true;
            }
        }

        private void startGame()
        {
            //we don't see label 3 at start of the game
            label3.Visible  =false;
            new Setting();
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            //setting label2
            label2.Text = Setting.score.ToString();
            generateFood();
        }

        private void generateFood() 
        {
            //generating food inside
            int maxXpos = pbgraphic.Size.Width / Setting.Width;
            int maxYpos = pbgraphic.Size.Height / Setting.Height;
            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXpos), Y = random.Next(0, maxYpos) };
        }

        private void eat()
        {
            //eating food function
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body); 
            Setting.Score += Setting.Points;
            label2.Text = Setting.Score.ToString();

            //generating another food after the consumption
            generateFood();
        }

        private void end()
        {
            // change the game over Boolean to true
            Setting.GameOver = true;
        }
    }
}
