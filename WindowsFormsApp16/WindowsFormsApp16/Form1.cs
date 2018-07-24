using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int score = 0;
        int total_shots = 0;
        int miss_shots = 0;
        void shot_voice()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\rupin\Downloads\gun.wav");
            player.Play();
        }
        void fn_shot()
        {
            score++;
            label1.Text = "Score =" + score;
            total_shots++;
            label3.Text = "Total Shots=" + total_shots;

            shot_voice();
        }
        void fn_miss_shot()
        {
            miss_shots++;
            label2.Text = "Missing Shots=" + miss_shots;
            total_shots++;
            label3.Text = "Total Shots=" + total_shots;

            shot_voice();
         }

        void reset()
        {
            score = 0;
            miss_shots = 0;
            total_shots = 0;
            label2.Text = "Missing Shots=" + miss_shots;
            label3.Text = "Total Shots=" + total_shots;
            label1.Text = "Score =" + score;
            timer1.Start();
            label4.Text = "";

        }
        void fire()
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_miss_shot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0,500);
            y = r.Next(0,0);
            pictureBox1.Location = new Point(x, y);
            if(miss_shots>=6)
            { timer1.Stop();
                label4.Text="Game Over";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
