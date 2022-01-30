using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class books_registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2017data.mdf;Integrated Security=True");
        

        public books_registration()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void books_registration_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        


        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
            try
            {
                //MemoryStream ms = new MemoryStream();
                //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] imageBt = ms.GetBuffer();
                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.txt_abstract.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);

                string fileName = System.IO.Path.GetFileName(fstream.Name);
                string from = txt_abstract.Text;
                string to = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\pictures";

                if(!Directory.Exists(to))
                {
                    Directory.CreateDirectory(to);
                }

                to += "\\" + txt_id.Text + Path.GetExtension(from);

                System.IO.File.Copy(from, to, true);


                if (txt_id.Text == "" && txt_title.Text == "" && txt_mem1.Text == "" && txt_mem2.Text == "" && txt_mem3.Text == "" && txt_abstract.Text == "")
                {
                    MessageBox.Show("Please check the Textfield", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_data(ID, thesis_title, member_1, member_2, member_3, abstract, pic_image) VALUES(@ID, @thesis_title, @member_1, @member_2, @member_3, @abstract, @pic_image)", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text));
                        cmd.Parameters.AddWithValue("@thesis_title", txt_title.Text);
                        cmd.Parameters.AddWithValue("@member_1", txt_mem1.Text);
                        cmd.Parameters.AddWithValue("@member_2", txt_mem2.Text);
                        cmd.Parameters.AddWithValue("@member_3", txt_mem3.Text);
                        cmd.Parameters.AddWithValue("@abstract", to);
                        cmd.Parameters.AddWithValue("@pic_image", imageBt);
                        cmd.ExecuteNonQuery();
                    }

                    timer1.Start();
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
                gunaProgressBar1.Maximum = 0;
                MessageBox.Show("Books successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Text = "";
                txt_title.Text = "";
                txt_mem1.Text = "";
                txt_mem2.Text = "";
                txt_mem3.Text = "";
                txt_abstract.Text = "";
                panel2.Visible = false;

            }
        }

        OpenFileDialog dlg = new OpenFileDialog();

        private void gunaButton3_Click(object sender, EventArgs e)
        {
          
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txt_abstract.Text = picPath;
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
