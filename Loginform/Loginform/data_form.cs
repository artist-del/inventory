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
    public partial class data_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2017data.mdf;Integrated Security=True");
        public data_form()
        {
            InitializeComponent();
        }

        private void data_form_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            data();
        }

        
        
        public void data()
        {

            SqlCommand cmd = new SqlCommand("SELECT  ID, thesis_title, member_1,member_2, member_3, abstract FROM tbl_data", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT  ID, thesis_title, member_1,member_2, member_3, abstract FROM tbl_data WHERE thesis_title LIKE '%" + gunaTextBox1.Text + "%'", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //public Image ConvertByteArrayToImage(byte[] data)
        //{
        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Convert.ToInt32(gunaDataGridView1.SelectedCells[4].Value.ToString());

            if (gunaDataGridView1.Columns[e.ColumnIndex].Name == "btn_update")
            {
                Loginform.update_form uf = new update_form();
                uf.txt_id.Text = this.gunaDataGridView1.SelectedCells[4].Value.ToString();
                uf.txt_title.Text = this.gunaDataGridView1.SelectedCells[5].Value.ToString();
                uf.txt_mem1.Text = this.gunaDataGridView1.SelectedCells[6].Value.ToString();
                uf.txt_mem2.Text = this.gunaDataGridView1.SelectedCells[7].Value.ToString();
                uf.txt_mem3.Text = this.gunaDataGridView1.SelectedCells[8].Value.ToString();
                uf.txt_abstract.Text = this.gunaDataGridView1.SelectedCells[9].Value.ToString();
                uf.pictureBox1.ImageLocation = this.gunaDataGridView1.SelectedCells[9].Value.ToString();
                gunaTransition1.ShowSync(uf);
                uf.Show();
            }
            if (gunaDataGridView1.Columns[e.ColumnIndex].Name == "btn_view")
            {
                Loginform.view_details vd = new view_details();
                vd.txt_id.Text = this.gunaDataGridView1.SelectedCells[4].Value.ToString();
                vd.txt_title.Text = this.gunaDataGridView1.SelectedCells[5].Value.ToString();
                vd.txt_mem1.Text = this.gunaDataGridView1.SelectedCells[6].Value.ToString();
                vd.txt_mem2.Text = this.gunaDataGridView1.SelectedCells[7].Value.ToString();
                vd.txt_mem3.Text = this.gunaDataGridView1.SelectedCells[8].Value.ToString();
                vd.pictureBox1.ImageLocation = this.gunaDataGridView1.SelectedCells[9].Value.ToString();
                gunaTransition1.ShowSync(vd);
                vd.Show();
            }
            if (gunaDataGridView1.Columns[e.ColumnIndex].Name == "btn_delete")
            {
                if (MessageBox.Show("Do you want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_data WHERE ID = '" + i + "'", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    data();
                }
            }
            if (gunaDataGridView1.Columns[e.ColumnIndex].Name == "btn_print")
            {
               
                

                Loginform.printForm pf = new printForm();
                pf.txt_id.Text = this.gunaDataGridView1.SelectedCells[4].Value.ToString();
                pf.txt_title.Text = this.gunaDataGridView1.SelectedCells[5].Value.ToString();
                pf.txt_mem1.Text = this.gunaDataGridView1.SelectedCells[6].Value.ToString();
                pf.txt_mem2.Text = this.gunaDataGridView1.SelectedCells[7].Value.ToString();
                pf.txt_mem3.Text = this.gunaDataGridView1.SelectedCells[8].Value.ToString();
                pf.pictureBox1.ImageLocation = this.gunaDataGridView1.SelectedCells[9].Value.ToString();
                gunaTransition1.ShowSync(pf);
                pf.Show();
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            data();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dt = gunaDataGridView1.DataSource as DataTable;
            //if (dt != null)
            //{
            //    DataRow row = dt.Rows[e.RowIndex];
            //    pictureBox2.Image = ConvertByteArrayToImage((byte[])row["abstract"]);
            //}
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
