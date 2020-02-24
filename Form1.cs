using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameControl
{
    public partial class Form1 : Form
    {
        public static bool on = false;
        private int camCycle = 0;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = true;
        }

        void Update()
        {
            if (on == true)
            {
                button2.Enabled = true;            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            camCycle = camCycle++;
            camCycle = camCycle % 3;

            off();

            if (camCycle == 0)
                cam1.Enabled = true;
            if (camCycle == 1)
                cam2.Enabled = true;
            if (camCycle == 2)
                cam3.Enabled = true;
        }

        private void off()
        {
            cam1.Enabled = false;
            cam3.Enabled = false;
            cam3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load Game Scene
            Program.state = 0;
        }
    }
}
