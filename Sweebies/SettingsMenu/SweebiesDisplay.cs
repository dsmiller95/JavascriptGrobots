using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweebies
{
    public partial class SweebiesDisplay : Form
    {

        Environment env;
        Random r;

        public SweebiesDisplay() : this("rock", 10)
        {
        }

        public SweebiesDisplay(String name, int number)
        {
            r = new Random();
            InitializeComponent();
            env = new Environment(Width, Height);


            label1.Text = name;
            label2.Text = number.ToString();
            if(name.ToLower() == "rock")
            {
                for(int i = 0; i < number; i++)
                {
                    env.addActor(new Actors.Rock(new Point(r.Next(Width), r.Next(Height)), 20));
                }
            }

            timer1.Enabled = true;

        }

        private void drawEnvironment(Environment env)
        {
            Graphics g = this.CreateGraphics();

            env.drawActorsOn(g);

            g.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawEnvironment(env);
        }
    }
}