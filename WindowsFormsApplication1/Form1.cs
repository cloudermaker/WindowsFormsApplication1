using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Principal p { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // test de connection à prévoir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.p = new Principal(this);
            this.Hide();
            this.p.Show();
        }
    }
}
