using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bms_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cupcakebtn_Click_1(object sender, EventArgs e)
        {
            cupcake1.Show();
            cupcake1.BringToFront();
            panel2.Show();
            cake1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cookies1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void savorybtn_Click_1(object sender, EventArgs e)
        {
            savory1.Show();
            savory1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            cake1.Hide();
            sweats1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void browniesbtn_Click_1(object sender, EventArgs e)
        {
            brownies1.Show();
            brownies1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cupcake1.Hide();
            cake1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void sweatsbtn_Click_1(object sender, EventArgs e)
        {
            sweats1.Show();
            sweats1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            savory1.Hide();
            cake1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            splashscreen1.Show();
            splashscreen1.BringToFront();
            panel2.Show();
            sweats1.Hide();
            cookies1.Hide();
            savory1.Hide();
            cake1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            billing1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
            cake1.Hide();
            cookies1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sweats1.Hide();
            billing1.Show();
            billing1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            savory1.Hide();
            cake1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
        }

        private void cakebtn_Click(object sender, EventArgs e)
        {
            cake1.Show();
            cake1.BringToFront();
            panel2.Show();
            cupcake1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cookies1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void cookiesbtn_Click(object sender, EventArgs e)
        {
            cookies1.Show();
            cookies1.BringToFront();
            panel2.Show();
            cake1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void cupcakebtn_Click(object sender, EventArgs e)
        {
            cupcake1.Show();
            cupcake1.BringToFront();
            panel2.Show();
            cake1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cookies1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void savorybtn_Click(object sender, EventArgs e)
        {
            savory1.Show();
            savory1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            cake1.Hide();
            sweats1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void browniesbtn_Click(object sender, EventArgs e)
        {
            brownies1.Show();
            brownies1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            savory1.Hide();
            sweats1.Hide();
            cupcake1.Hide();
            cake1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void sweatsbtn_Click(object sender, EventArgs e)
        {
            sweats1.Show();
            sweats1.BringToFront();
            panel2.Show();
            cookies1.Hide();
            savory1.Hide();
            cake1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            splashscreen1.Hide();
            billing1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splashscreen1.Show();
            splashscreen1.BringToFront();
            panel2.Show();
            sweats1.Hide();
            cookies1.Hide();
            savory1.Hide();
            cake1.Hide();
            cupcake1.Hide();
            brownies1.Hide();
            billing1.Hide();
        }

        
    }
}
