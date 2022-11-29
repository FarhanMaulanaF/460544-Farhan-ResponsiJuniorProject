namespace Responsi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_namaKaryawan = new System.Windows.Forms.Label();
            this.lbl_depKaryawan = new System.Windows.Forms.Label();
            this.tb_namaKaryawan = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_hrHelper = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_depKaryawan = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_namaKaryawan
            // 
            this.lbl_namaKaryawan.AutoSize = true;
            this.lbl_namaKaryawan.Location = new System.Drawing.Point(12, 58);
            this.lbl_namaKaryawan.Name = "lbl_namaKaryawan";
            this.lbl_namaKaryawan.Size = new System.Drawing.Size(99, 15);
            this.lbl_namaKaryawan.TabIndex = 0;
            this.lbl_namaKaryawan.Text = "Nama Karyawan :";
            // 
            // lbl_depKaryawan
            // 
            this.lbl_depKaryawan.AutoSize = true;
            this.lbl_depKaryawan.Location = new System.Drawing.Point(12, 94);
            this.lbl_depKaryawan.Name = "lbl_depKaryawan";
            this.lbl_depKaryawan.Size = new System.Drawing.Size(91, 15);
            this.lbl_depKaryawan.TabIndex = 1;
            this.lbl_depKaryawan.Text = "Dep. Karyawan :";
            // 
            // tb_namaKaryawan
            // 
            this.tb_namaKaryawan.Location = new System.Drawing.Point(117, 55);
            this.tb_namaKaryawan.Name = "tb_namaKaryawan";
            this.tb_namaKaryawan.Size = new System.Drawing.Size(185, 23);
            this.tb_namaKaryawan.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 132);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(290, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_hrHelper
            // 
            this.lbl_hrHelper.AutoSize = true;
            this.lbl_hrHelper.Location = new System.Drawing.Point(64, 25);
            this.lbl_hrHelper.Name = "lbl_hrHelper";
            this.lbl_hrHelper.Size = new System.Drawing.Size(61, 15);
            this.lbl_hrHelper.TabIndex = 7;
            this.lbl_hrHelper.Text = "HR Helper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(117, 132);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(227, 132);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_depKaryawan
            // 
            this.tb_depKaryawan.Location = new System.Drawing.Point(117, 91);
            this.tb_depKaryawan.Name = "tb_depKaryawan";
            this.tb_depKaryawan.Size = new System.Drawing.Size(185, 23);
            this.tb_depKaryawan.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.comboBox1.Location = new System.Drawing.Point(117, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 335);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_depKaryawan);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_hrHelper);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_namaKaryawan);
            this.Controls.Add(this.lbl_depKaryawan);
            this.Controls.Add(this.lbl_namaKaryawan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_namaKaryawan;
        private Label lbl_depKaryawan;
        private TextBox tb_namaKaryawan;
        private Button btn_insert;
        private DataGridView dataGridView1;
        private Label lbl_hrHelper;
        private PictureBox pictureBox1;
        private Button btn_edit;
        private Button btn_delete;
        private TextBox tb_depKaryawan;
        private ComboBox comboBox1;
    }
}