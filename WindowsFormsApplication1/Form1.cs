using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Form3 secondpage = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Contains("Admin") & (textBox2.Text == "Pass")))
            {
                secondpage.Show();
            };
        }
    }
}
