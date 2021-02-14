using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Soccer
{
    
    public partial class Form1 : Form
    {
        private List<Goal> _goals;
        private List<Player> _players;
        private List<Computer> _computers;
        private bool keyPress;
        private Ball _ball;
        private int redScore;
        private int blueScore;
        
        public Form1()
        {
            InitializeComponent();
            _goals = new List<Goal>();
            _players = new List<Player>();
            _computers = new List<Computer>();
            _players.Add(new Player(pictureBox1.Width / 4, pictureBox1.Height / 2, Team.Blue));
            _computers.Add(new Computer((pictureBox1.Width / 4) * 3, pictureBox1.Height / 2, Team.Red));
            _goals.Add(new Goal(30, pictureBox1.Height / 2, 60, 150, Team.Blue));
            _goals.Add(new Goal(pictureBox1.Width - 30, pictureBox1.Height / 2, 60, 150, Team.Red));
            _ball = new Ball(pictureBox1);
            keyPress = false;
            redScore = 0;
            blueScore = 0;
            MessageBox.Show("Welcome to my Game\nYou are the blue ball\nYour goal is to hit the gold ball into the goal\nOn the right side of the screen\nHowever you are facing a computer player\nTo control your ball you must push and hold the space key\nWhile holding said key you will deccelerate and turn\nEvery time you press the key you will turn in the opposite direction\nWhile the key is released you will accelerate\nGood Luck and Have Fun");
        }

        private void AnimationTimerTick(object sender, EventArgs e)
        {
            foreach (Player car in _players)
            {
                car.Advance();
                car.WallCollide(pictureBox1);
                car.IfOOB(pictureBox1);
            }
            foreach (Computer car in _computers)
            {
                car.Advance(_ball);
                car.WallCollide(pictureBox1);
                car.IfOOB(pictureBox1);
            }
            _ball.IsCollide(_players,_computers);
            _ball.Advance();
            _ball.IfOOB(pictureBox1);
            switch (_ball.IsInGoal(_goals))
            {
                case Team.Red:
                    redScore += 1;
                    _ball.Reset(pictureBox1);
                    break;
                case Team.Blue:
                    blueScore += 1;
                    _ball.Reset(pictureBox1);
                    break;
                default:
                    break;
            }
            _ball.WallCollide(pictureBox1);
            if(redScore >= 5)
            {
                GameEnd(Team.Red);
            }
            else if(blueScore >= 5)
            {
                GameEnd(Team.Blue);
            }
            pictureBox1.Refresh();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keyPress)
            {
                foreach (Player player in _players)
                {
                    player.InputDown(e);
                }
                keyPress = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyPress)
            {
                foreach (Player player in _players)
                {
                    player.InputUp(e);
                }
                keyPress = false;
            }
        }
        private void Draw(Graphics paper)
        {
            DrawField(paper);
            foreach (Car car in _players)
            {
                car.Draw(paper);
            }
            foreach (Car car in _computers)
            {
                car.Draw(paper);
            }
            foreach(Goal goal in _goals)
            {
                goal.Draw(paper);
            }
            _ball.Draw(paper);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics paper = e.Graphics;
            Draw(paper);
        }
        private double DegToRad(double degrees)
        {
            return degrees / 180 * Math.PI;
        }
        private void DrawField(Graphics paper)
        {
            Brush br = new SolidBrush(Color.LightGreen);
            paper.FillRectangle(br, 0, 0, pictureBox1.Width, pictureBox1.Height);
            br = new SolidBrush(Color.Black);
            paper.FillRectangle(br, 0, 0, 60, pictureBox1.Height);
            paper.FillRectangle(br, pictureBox1.Width - 60, 0, pictureBox1.Width, pictureBox1.Height);
            FontFamily fontFamily = new FontFamily("Comic sans MS");
            Font font = new Font(
                fontFamily,
                16,
                FontStyle.Regular);
            br = new SolidBrush(Color.Red);
            paper.DrawString("Red Score: " + redScore.ToString(), font, br, pictureBox1.Width - 200, 0);
            br = new SolidBrush(Color.Blue);
            paper.DrawString("Blue Score: " + blueScore.ToString(), font, br, 60, 0);
        }
        private void GameEnd(Team team)
        {
            _animationTimer.Enabled = false;
            MessageBox.Show(team.ToString() + " team wins!");
        }
        public PointF BallPoint()
        {
            return new PointF(_ball.X, _ball.Y);
        }

        
    }
}
