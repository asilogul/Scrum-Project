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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                tabControl1.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
