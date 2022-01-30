using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Form1 ot = new Form1();
            gunaTransition1.ShowSync(ot);
            ot.Show();
            this.Hide();

        }
        private static books_registration br = new books_registration();
        
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (!br.Visible)
            {
                gunaTransition1.ShowSync(br);
                br.Show();
            }
            else
            {
                br.BringToFront();
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static data_form df = new data_form();
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (!df.Visible)
            {
                gunaTransition1.ShowSync(df);
                df.Show();
            }
            else
            {
                df.BringToFront();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
