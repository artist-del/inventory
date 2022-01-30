using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loginform
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2017data.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int count = 0;

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_login WHERE username = '" + txt_user.Text + "' AND password = '" + txt_pass.Text + "'", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());

            if (count > 0)
            {
                timer1.Start();
                gunaLabel4.Visible = true;
                gunaProgressBar1.Visible = true;
                errorPanel.Visible = false;

            }
            else
            {
                errorPanel.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaProgressBar1.Increment(3);
            gunaProgressBar1.Maximum = 100;

            if (gunaProgressBar1.Value == gunaProgressBar1.Maximum)
            {
                timer1.Stop();
                main_form mf = new main_form();
                gunaTransition1.ShowSync(mf);
                mf.Show();
                this.Hide();
                gunaLabel4.Text = "Loading Complete!";
                gunaProgressBar1.Visible = false;
                gunaLabel4.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            permission_form pf = new permission_form();
            gunaTransition1.ShowSync(pf);
            pf.Show();
            this.Hide();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaButton1.PerformClick();
            }
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaButton1.PerformClick();
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
