using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caseStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           datelbl.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "username";
            string password = "password";
            if (textBox1.Text == username && textBox2.Text == password)
            {
                home home = new home();
                home.Show();
                this.Hide();


               /* Form2 form2 = new Form2();

                form2.Show();

                this.Hide();*/
            }
            else
            {
                MessageBox.Show("Access Denied!..", "Log In", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void datelbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
  