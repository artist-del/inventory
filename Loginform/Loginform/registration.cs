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
    public partial class registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2017data.mdf;Integrated Security=True");
        public registration()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                if (txt_user.Text == "" && txt_pass.Text == "")
                {
                    MessageBox.Show("Please fillup the textfield", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_login WHERE username='" + txt_user.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    count = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (count == 0)
                    {
                        timer1.Start();
                        gunaProgressBar1.Visible = true;
                        gunaLabel4.Visible = true;
                        SqlCommand cmdd = new SqlCommand("INSERT INTO tbl_login(username, password) VALUES ('" + txt_user.Text + "', '" + txt_pass.Text + "')", con);
                        cmdd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Username already exist!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaProgressBar1.Increment(3);
            gunaProgressBar1.Maximum = 100;

            if (gunaProgressBar1.Value == gunaProgressBar1.Maximum)
            {
                timer1.Stop();
                gunaLabel4.Text = "Registered succesfully";
                MessageBox.Show("Registered succesfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gunaProgressBar1.Maximum = 0;
                gunaProgressBar1.Visible = false;
                gunaLabel4.Visible = false;
                gunaLabel4.Text = "Please wait . . .";
                txt_user.Text = "";
                txt_pass.Text = "";
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            gunaTransition1.ShowSync(fr);
            fr.Show();
            this.Hide();
        }
    }
}
