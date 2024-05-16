using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form form = new FormBUtton(); 
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formTextBOX =new FormTextBox();
            formTextBOX.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formTimer = new FormTimer();
            formTimer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formTimer = new FormGame();
            formTimer.Show();
        }
    }
}
