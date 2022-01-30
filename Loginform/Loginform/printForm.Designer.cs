namespace Loginform
{
    partial class printForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printForm));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_mem3 = new System.Windows.Forms.TextBox();
            this.txt_mem2 = new System.Windows.Forms.TextBox();
            this.txt_mem1 = new System.Windows.Forms.TextBox();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_dash = new System.Windows.Forms.Label();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.gunaGroupBox1.Controls.Add(this.txt_title);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(102)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(43, 147);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(441, 145);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "THESIS TITLE";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(20, 5);
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.txt_title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.Color.White;
            this.txt_title.Location = new System.Drawing.Point(38, 46);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(362, 81);
            this.txt_title.TabIndex = 0;
            this.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gray;
            this.gunaGroupBox2.Controls.Add(this.txt_mem3);
            this.gunaGroupBox2.Controls.Add(this.txt_mem2);
            this.gunaGroupBox2.Controls.Add(this.txt_mem1);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(102)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(43, 298);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 10;
            this.gunaGroupBox2.Size = new System.Drawing.Size(441, 177);
            this.gunaGroupBox2.TabIndex = 12;
            this.gunaGroupBox2.Text = "MEMBER";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(20, 5);
            // 
            // txt_mem3
            // 
            this.txt_mem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.txt_mem3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mem3.ForeColor = System.Drawing.Color.White;
            this.txt_mem3.Location = new System.Drawing.Point(38, 128);
            this.txt_mem3.Name = "txt_mem3";
            this.txt_mem3.ReadOnly = true;
            this.txt_mem3.Size = new System.Drawing.Size(362, 29);
            this.txt_mem3.TabIndex = 2;
            this.txt_mem3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mem2
            // 
            this.txt_mem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.txt_mem2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mem2.ForeColor = System.Drawing.Color.White;
            this.txt_mem2.Location = new System.Drawing.Point(38, 88);
            this.txt_mem2.Name = "txt_mem2";
            this.txt_mem2.ReadOnly = true;
            this.txt_mem2.Size = new System.Drawing.Size(362, 29);
            this.txt_mem2.TabIndex = 1;
            this.txt_mem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mem1
            // 
            this.txt_mem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.txt_mem1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mem1.ForeColor = System.Drawing.Color.White;
            this.txt_mem1.Location = new System.Drawing.Point(38, 46);
            this.txt_mem1.Name = "txt_mem1";
            this.txt_mem1.ReadOnly = true;
            this.txt_mem1.Size = new System.Drawing.Size(362, 29);
            this.txt_mem1.TabIndex = 0;
            this.txt_mem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gray;
            this.gunaGroupBox3.Controls.Add(this.btn_print);
            this.gunaGroupBox3.Controls.Add(this.pictureBox1);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaGroupBox3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(102)))));
            this.gunaGroupBox3.Location = new System.Drawing.Point(490, 47);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Radius = 10;
            this.gunaGroupBox3.Size = new System.Drawing.Size(441, 428);
            this.gunaGroupBox3.TabIndex = 13;
            this.gunaGroupBox3.Text = "THESIS ABSTRACT";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(20, 5);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(302, 374);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(117, 38);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.pictureBox1.Location = new System.Drawing.Point(20, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 35);
            this.panel1.TabIndex = 14;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(4, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(99, 25);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Print Data";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(925, 0);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(40, 33);
            this.gunaButton2.TabIndex = 7;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gray;
            this.gunaGroupBox4.Controls.Add(this.txt_id);
            this.gunaGroupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaGroupBox4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(102)))));
            this.gunaGroupBox4.Location = new System.Drawing.Point(43, 47);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Radius = 10;
            this.gunaGroupBox4.Size = new System.Drawing.Size(441, 94);
            this.gunaGroupBox4.TabIndex = 10;
            this.gunaGroupBox4.Text = "ID";
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(20, 5);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(3)))), ((int)(((byte)(41)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.White;
            this.txt_id.Location = new System.Drawing.Point(38, 46);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(362, 29);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // lbl_dash
            // 
            this.lbl_dash.AutoSize = true;
            this.lbl_dash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dash.Location = new System.Drawing.Point(174, 474);
            this.lbl_dash.Name = "lbl_dash";
            this.lbl_dash.Size = new System.Drawing.Size(538, 24);
            this.lbl_dash.TabIndex = 15;
            this.lbl_dash.Text = "---------------------------------------------------------------------------------" +
    "-------";
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(13)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(968, 487);
            this.Controls.Add(this.lbl_dash);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "printForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printForm";
            this.Load += new System.EventHandler(this.printForm_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.gunaGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        public System.Windows.Forms.TextBox txt_title;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        public System.Windows.Forms.TextBox txt_mem3;
        public System.Windows.Forms.TextBox txt_mem2;
        public System.Windows.Forms.TextBox txt_mem1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_dash;
    }
}