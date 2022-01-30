using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class printForm : Form
    {
        public printForm()
        {
            InitializeComponent();
        }

        private void printForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            try
            {
               
                Bitmap bmp = Properties.Resources.logo;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 560, 70, newImage.Width, newImage.Height);
                e.Graphics.DrawString("ROMBLON STATE UNIVERSITY", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(240, 110));
                e.Graphics.DrawString("CAJIDIOCAN, ROMBLON", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(265, 135));
                //dash
                e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(30, 210));
                //thesis title
                e.Graphics.DrawString("THESIS TITLE:", new System.Drawing.Font("Tahoma", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(45, 260));
                e.Graphics.DrawString(txt_title.Text, new System.Drawing.Font("Tahoma", 20, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(245, 260));

                //dash
                e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(30, 410));


                //member
                e.Graphics.DrawString("MEMBER: ", new System.Drawing.Font("Tahoma", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(45, 450));

                e.Graphics.DrawString(txt_mem1.Text, new System.Drawing.Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(245, 450));
                e.Graphics.DrawString(txt_mem2.Text, new System.Drawing.Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(245, 480));
                e.Graphics.DrawString(txt_mem3.Text, new System.Drawing.Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(245, 510));

                //dash
                e.Graphics.DrawString(lbl_dash.Text, new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(30, 560));


                //abstract image
                e.Graphics.DrawString("ABSTRACT:", new System.Drawing.Font("Tahoma", 18, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(45, 600));
                e.Graphics.DrawImage(pictureBox1.Image, 245, 600, newImage.Width * 3, newImage.Height * 3);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
