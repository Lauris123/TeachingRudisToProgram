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
        }
        int x = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            x ++;
            lbl1.Text = x .ToString();
            //Laibais 
        }
    }
}
