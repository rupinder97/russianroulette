using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russianroulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game = new Game();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.start();
            button2.Enabled = false;
            label2.Text = "Gun Loaded and Spinned.";
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fire = game.fire();
            if(fire == "killed")
            {
                label2.Text = "You are killed.";
                label2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.fireAway();
        }
    }
}
