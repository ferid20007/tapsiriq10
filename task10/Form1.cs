using System.Media;
using System.Numerics;

namespace task10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
        }
        bool engineOn = false;
        private void button8_Click(object sender, EventArgs e)
        {
            if (engineOn == false)
            {
                engineOn = true;
                button8.Text = "ON";
                SoundPlayer startSound = new SoundPlayer("vin vin.wav");
                startSound.Play();
            }
            else
            {
                engineOn = false;
                button8.Text = "OFF";

                timer1.Stop();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (engineOn)
            {
                timer2.Stop();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Evvelce muherriki ise salin!");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Yolun sonu");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (engineOn)
            {
                timer1.Stop();
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Evvelce muherriki ise salin!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("inishazirliklari.wav");
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("turbulans.wav");
            sp.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("kemerler.wav");
            sp.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("tesekkurler.wav");
            sp.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("beep.wav");
            sp.Play();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 420)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Enis zolaginin sonu!");
            }
        }
    }
}
