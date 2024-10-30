namespace QuanLyNganHang_BT
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
            ListViewItem listViewItem1 = new ListViewItem("Cơ sở dữ liệu");
            ListViewItem listViewItem2 = new ListViewItem("Cơ sở DL NC");
            ListViewItem listViewItem3 = new ListViewItem("PTTK Hệ Thống Thông Tin");
            groupBox1 = new GroupBox();
            button_XoaChon = new Button();
            button_LuuThongTin = new Button();
            listView_RES_MonHocThamGia = new ListView();
            button2_BACK = new Button();
            button1_TO = new Button();
            listView_MonHocThamGia = new ListView();
            radioButton_Nu = new RadioButton();
            radioButton_Nam = new RadioButton();
            comboBox_ChuyenNganh = new ComboBox();
            textBox_HoTen = new TextBox();
            textBox_mssv = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView = new DataGridView();
            Column_MSSV = new DataGridViewTextBoxColumn();
            Column_HoTen = new DataGridViewTextBoxColumn();
            Column_ChuyenNganh = new DataGridViewTextBoxColumn();
            Column_GioiTinh = new DataGridViewTextBoxColumn();
            Column_SoMon = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_XoaChon);
            groupBox1.Controls.Add(button_LuuThongTin);
            groupBox1.Controls.Add(listView_RES_MonHocThamGia);
            groupBox1.Controls.Add(button2_BACK);
            groupBox1.Controls.Add(button1_TO);
            groupBox1.Controls.Add(listView_MonHocThamGia);
            groupBox1.Controls.Add(radioButton_Nu);
            groupBox1.Controls.Add(radioButton_Nam);
            groupBox1.Controls.Add(comboBox_ChuyenNganh);
            groupBox1.Controls.Add(textBox_HoTen);
            groupBox1.Controls.Add(textBox_mssv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // button_XoaChon
            // 
            button_XoaChon.Location = new Point(366, 295);
            button_XoaChon.Name = "button_XoaChon";
            button_XoaChon.Size = new Size(94, 29);
            button_XoaChon.TabIndex = 15;
            button_XoaChon.Text = "Xóa chọn";
            button_XoaChon.UseVisualStyleBackColor = true;
            button_XoaChon.Click += button_XoaChon_Click;
            // 
            // button_LuuThongTin
            // 
            button_LuuThongTin.Location = new Point(235, 295);
            button_LuuThongTin.Name = "button_LuuThongTin";
            button_LuuThongTin.Size = new Size(120, 29);
            button_LuuThongTin.TabIndex = 14;
            button_LuuThongTin.Text = "Lưu thông tin";
            button_LuuThongTin.UseVisualStyleBackColor = true;
            button_LuuThongTin.Click += button_LuuThongTin_Click;
            // 
            // listView_RES_MonHocThamGia
            // 
            listView_RES_MonHocThamGia.Location = new Point(433, 187);
            listView_RES_MonHocThamGia.Name = "listView_RES_MonHocThamGia";
            listView_RES_MonHocThamGia.Size = new Size(220, 102);
            listView_RES_MonHocThamGia.TabIndex = 13;
            listView_RES_MonHocThamGia.UseCompatibleStateImageBehavior = false;
            listView_RES_MonHocThamGia.View = View.List;
            // 
            // button2_BACK
            // 
            button2_BACK.Location = new Point(361, 240);
            button2_BACK.Name = "button2_BACK";
            button2_BACK.Size = new Size(66, 29);
            button2_BACK.TabIndex = 12;
            button2_BACK.Text = "<";
            button2_BACK.UseVisualStyleBackColor = true;
            button2_BACK.Click += button2_BACK_Click;
            // 
            // button1_TO
            // 
            button1_TO.Location = new Point(361, 205);
            button1_TO.Name = "button1_TO";
            button1_TO.Size = new Size(66, 29);
            button1_TO.TabIndex = 11;
            button1_TO.Text = ">";
            button1_TO.UseVisualStyleBackColor = true;
            button1_TO.Click += button1_TO_Click;
            // 
            // listView_MonHocThamGia
            // 
            listView_MonHocThamGia.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView_MonHocThamGia.Location = new Point(135, 187);
            listView_MonHocThamGia.Name = "listView_MonHocThamGia";
            listView_MonHocThamGia.Size = new Size(220, 102);
            listView_MonHocThamGia.TabIndex = 10;
            listView_MonHocThamGia.UseCompatibleStateImageBehavior = false;
            listView_MonHocThamGia.View = View.List;
            // 
            // radioButton_Nu
            // 
            radioButton_Nu.AutoSize = true;
            radioButton_Nu.Location = new Point(377, 130);
            radioButton_Nu.Name = "radioButton_Nu";
            radioButton_Nu.Size = new Size(50, 24);
            radioButton_Nu.TabIndex = 9;
            radioButton_Nu.TabStop = true;
            radioButton_Nu.Text = "Nữ";
            radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            radioButton_Nam.AutoSize = true;
            radioButton_Nam.Location = new Point(309, 130);
            radioButton_Nam.Name = "radioButton_Nam";
            radioButton_Nam.Size = new Size(62, 24);
            radioButton_Nam.TabIndex = 8;
            radioButton_Nam.TabStop = true;
            radioButton_Nam.Text = "Nam";
            radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // comboBox_ChuyenNganh
            // 
            comboBox_ChuyenNganh.FormattingEnabled = true;
            comboBox_ChuyenNganh.Items.AddRange(new object[] { "Hệ thống thông tin ", "Kỹ thuật phần mềm ", "Khoa học máy tính " });
            comboBox_ChuyenNganh.Location = new Point(309, 88);
            comboBox_ChuyenNganh.Name = "comboBox_ChuyenNganh";
            comboBox_ChuyenNganh.Size = new Size(169, 28);
            comboBox_ChuyenNganh.TabIndex = 7;
            // 
            // textBox_HoTen
            // 
            textBox_HoTen.Location = new Point(309, 53);
            textBox_HoTen.Name = "textBox_HoTen";
            textBox_HoTen.Size = new Size(169, 27);
            textBox_HoTen.TabIndex = 6;
            // 
            // textBox_mssv
            // 
            textBox_mssv.Location = new Point(309, 20);
            textBox_mssv.Name = "textBox_mssv";
            textBox_mssv.Size = new Size(169, 27);
            textBox_mssv.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 164);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 4;
            label5.Text = "Chọn các môn học tham gia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 130);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 91);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Chuyên ngành";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 56);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // dataGridView
            // 
            dataGridView.AccessibleName = "";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column_MSSV, Column_HoTen, Column_ChuyenNganh, Column_GioiTinh, Column_SoMon });
            dataGridView.Location = new Point(12, 348);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(776, 188);
            dataGridView.TabIndex = 1;
            dataGridView.RowEnter += RowEnterDataGridView;
            // 
            // Column_MSSV
            // 
            Column_MSSV.DataPropertyName = "MSSV";
            Column_MSSV.HeaderText = "MSSV";
            Column_MSSV.MinimumWidth = 6;
            Column_MSSV.Name = "Column_MSSV";
            Column_MSSV.ReadOnly = true;
            // 
            // Column_HoTen
            // 
            Column_HoTen.DataPropertyName = "HoTen";
            Column_HoTen.HeaderText = "Họ Tên";
            Column_HoTen.MinimumWidth = 6;
            Column_HoTen.Name = "Column_HoTen";
            Column_HoTen.ReadOnly = true;
            // 
            // Column_ChuyenNganh
            // 
            Column_ChuyenNganh.DataPropertyName = "ChuyenNganh";
            Column_ChuyenNganh.HeaderText = "Chuyên ngành";
            Column_ChuyenNganh.MinimumWidth = 6;
            Column_ChuyenNganh.Name = "Column_ChuyenNganh";
            Column_ChuyenNganh.ReadOnly = true;
            // 
            // Column_GioiTinh
            // 
            Column_GioiTinh.DataPropertyName = "GioiTinh";
            Column_GioiTinh.HeaderText = "Giới tính";
            Column_GioiTinh.MinimumWidth = 6;
            Column_GioiTinh.Name = "Column_GioiTinh";
            Column_GioiTinh.ReadOnly = true;
            // 
            // Column_SoMon
            // 
            Column_SoMon.DataPropertyName = "SoMon";
            Column_SoMon.HeaderText = "Số môn";
            Column_SoMon.MinimumWidth = 6;
            Column_SoMon.Name = "Column_SoMon";
            Column_SoMon.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(dataGridView);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox_ChuyenNganh;
        private TextBox textBox_HoTen;
        private TextBox textBox_mssv;
        private Label label5;
        private Label label4;
        private RadioButton radioButton_Nam;
        private ListView listView_MonHocThamGia;
        private RadioButton radioButton_Nu;
        private ListView listView_RES_MonHocThamGia;
        private Button button2_BACK;
        private Button button1_TO;
        private Button button_XoaChon;
        private Button button_LuuThongTin;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column_MSSV;
        private DataGridViewTextBoxColumn Column_HoTen;
        private DataGridViewTextBoxColumn Column_ChuyenNganh;
        private DataGridViewTextBoxColumn Column_GioiTinh;
        private DataGridViewTextBoxColumn Column_SoMon;
    }
}
