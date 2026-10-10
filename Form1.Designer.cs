namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            btnLocDat = new Button();
            dgvSinhVien = new DataGridView();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 87);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Điểm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 21);
            label3.Name = "label3";
            label3.Size = new Size(324, 20);
            label3.TabIndex = 2;
            label3.Text = "QUẢN LÝ SINH VIÊN - EF CORE (CRUD ĐẦY ĐỦ)";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(75, 84);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(230, 27);
            txtHoTen.TabIndex = 3;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(365, 84);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(140, 27);
            txtDiem.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 117);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(112, 117);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(211, 117);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(311, 117);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 29);
            btnTaiLai.TabIndex = 8;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(411, 117);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(94, 29);
            btnLocDat.TabIndex = 9;
            btnLocDat.Text = "Lọc SV đạt";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(12, 152);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(776, 286);
            dgvSinhVien.TabIndex = 10;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            dgvSinhVien.SelectionChanged += dgvSinhVien_SelectionChanged;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(511, 87);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 11;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private Button btnLocDat;
        private DataGridView dgvSinhVien;
        private Label lblTrangThai;
    }
}
