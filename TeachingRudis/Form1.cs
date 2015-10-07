using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachingRudis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            workingBlender();
            refresh();
        }
        int x = 0;
        int blenderCount = 0;
        int squeezerCount = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            x++;
            lbl1.Text = x.ToString();
            //Laibais 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x--;
                blenderCount++;
                label1.Text = blenderCount.ToString();
            }

        }
        private async void refresh()
        {
            while (true)
            {
                lbl1.Text = x.ToString();
                await Task.Delay(20);
            }
        }
        private async void workingBlender()
        {
            while (true)
            {
                x = x + blenderCount;
                x = x + squeezerCount * 5;
                await Task.Delay(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x > 9)
            {
               x = x-10;
                squeezerCount++;
                label2.Text = squeezerCount.ToString();
            }
        }
    }
}
