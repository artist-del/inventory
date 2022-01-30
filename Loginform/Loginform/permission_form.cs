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
    public partial class permission_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2017data.mdf;Integrated Security=True");
        public permission_form()
        {
            InitializeComponent();
        }

        private void permission_form_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_login WHERE username = '" + txt_user.Text + "' AND password = '" + txt_pass.Text + "'",con);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count == 0)
                {
                    MessageBox.Show("Please Check you Username and Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    registration rf = new registration();
                    gunaTransition1.ShowSync(rf);
                    rf.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            gunaTransition1.ShowSync(fr);
            fr.Show();
            this.Hide();
        }
    }
}
