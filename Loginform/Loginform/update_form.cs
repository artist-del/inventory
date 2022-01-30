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
using System.IO;

namespace Loginform
{
    public partial class update_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2017data.mdf;Integrated Security=True");

        public update_form()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.txt_abstract.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            //string fileName = System.IO.Path.GetFileName(fstream.Name);
            //string from = txt_abstract.Text;
            //string to = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\pictures";

            //if (!Directory.Exists(to))
            //{
            //    Directory.CreateDirectory(to);
            //}

            //to += "\\" + txt_id.Text + Path.GetExtension(from);

            //System.IO.File.Copy(from, to, true);

            try
            {
                if (txt_title.Text == "" && txt_mem1.Text == "" && txt_mem2.Text == "" && txt_mem3.Text == "" && txt_abstract.Text == "")
                {
                    MessageBox.Show("Please check the Textfield", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE tbl_data SET thesis_title = @title, member_1 = @mem1, member_2 = @mem2, member_3 = @mem3, abstract = @abstract, pic_image = @image WHERE ID = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@title", txt_title.Text);
                        cmd.Parameters.AddWithValue("@mem1", txt_mem1.Text);
                        cmd.Parameters.AddWithValue("@mem2", txt_mem2.Text);
                        cmd.Parameters.AddWithValue("@mem3", txt_mem3.Text);
                        cmd.Parameters.AddWithValue("@abstract", txt_abstract.Text);
                        cmd.Parameters.AddWithValue("@image", imageBt);
                        cmd.Parameters.AddWithValue("@id", txt_id.Text);
                        cmd.ExecuteNonQuery();
                    }
                    panel2.Visible = true;
                    timer1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaProgressBar1.Increment(5);
            gunaProgressBar1.Maximum = 100;

            if (gunaProgressBar1.Value == gunaProgressBar1.Maximum)
            {
                timer1.Stop();
                gunaLabel2.Text = "Updated Successfully";
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
                txt_title.Text = "";
                txt_mem1.Text = "";
                txt_mem2.Text = "";
                txt_mem3.Text = "";
                txt_abstract.Text = "";

                panel2.Visible = false;

            }
        }

        private void update_form_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txt_abstract.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }
    }
}
