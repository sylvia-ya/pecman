namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool goup, godown, goleft, goright = false;
        int pacmanspeed = 1;
        int score = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = Enabled;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            goup = godown = goleft = goright = false;
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        //private void Form1_KeyUp(object sender, KeyEventArgs e)
        //{
        //if (e.KeyCode == Keys.Up)
        //{
        // goup = false;
        //}
        // if (e.KeyCode == Keys.Down)
        //{
        // godown = false;
        //}
        //if (e.KeyCode == Keys.Left)
        // {
        //goleft = false;
        //}
        //if (e.KeyCode == Keys.Right)
        //{
        //goright = false;
        //}
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup)
            {
                pacman.Top -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanup;

            }
            else if (godown)
            {
                pacman.Top += pacmanspeed;
                pacman.Image = Properties.Resources.pacmandown;

            }
            else if (goleft)
            {
                pacman.Left -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanleft;

            }
            else if (goright)
            {
                pacman.Left += pacmanspeed;
                pacman.Image = Properties.Resources.pacman;

            }


            if (pacman.Bounds.IntersectsWith(pacman.Bounds))
            {
                pictureBox1.Visible = false;
                score += 1;
            }

            label1.Text = "X:" + pacman.Location.X + "Y:" + pacman.Location.Y;
        }
    }


}

