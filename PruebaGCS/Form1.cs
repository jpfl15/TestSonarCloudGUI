using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGCS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "HELLO WORLD";
            label2.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            //label2.Location = new Point(this.Width / 2 - label2.Width / 2, this.Height - label2.Height / 2);
        }

        
    }
}
