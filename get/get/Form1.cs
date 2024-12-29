using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void b1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="haider" && textBox2 .Text == "123")
            {
                MessageBox.Show("hello");
            } else
            {
                MessageBox.Show("worng");
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ahmr");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "saad" && textBox3.Text == "123")
            {
                MessageBox.Show("hello");
            }
            else
            {
                MessageBox.Show("worng");
            }
        }
    }
}
