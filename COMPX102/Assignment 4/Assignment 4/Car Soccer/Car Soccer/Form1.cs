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
        private List<Car> _cars;
        private bool keyPress;
        private Ball _ball;
        private int redScore;
        private int blueScore;
        public Form1()
        {
            InitializeComponent();
            _goals = new List<Goal>();
            _cars = new List<Car>();
            _cars.Add(new Player(pictureBox1.Width / 4, pictureBox1.Height / 2, Team.Blue));
            _goals.Add(new Goal(30, pictureBox1.Height / 2, 60, 150, Team.Blue));
            _goals.Add(new Goal(pictureBox1.Width - 30, pictureBox1.Height / 2, 60, 150, Team.Red));
            _ball = new Ball(pictureBox1);
            keyPress = false;
            redScore = 0;
            blueScore = 0;
        }

        private void AnimationTimerTick(object sender, EventArgs e)
        {
            foreach(Car car in _cars)
            {
                car.Advance();
                car.WallCollide(pictureBox1);
                car.IfOOB(pictureBox1);
            }
            _ball.IsCollide(_cars);
            _ball.Advance();
            _ball.IfOOB(pictureBox1);
            switch (_ball.IsInGoal(_goals))
            {
                case Team.Red:
                    blueScore += 1;
                    _ball.Reset(pictureBox1);
                    break;
                case Team.Blue:
                    redScore += 1;
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
                foreach (Player player in _cars)
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
                foreach (Player player in _cars)
                {
                    player.InputUp(e);
                }
                keyPress = false;
            }
        }
        private void Draw(Graphics paper)
        {
            DrawField(paper);
            foreach (Car car in _cars)
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
