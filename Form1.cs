using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace QuanLyNganHang_BT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class SinhVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string ChuyenNganh { get; set; }
            public string GioiTinh { get; set; }
            public List<string> MonHocThamGia { get; set; }

            public SinhVien()
            {
                MSSV = "";
                HoTen = "";
                ChuyenNganh = "Hệ thống thông tin";
                GioiTinh = "Nam";
                MonHocThamGia = new List<string>();
            }

            public void ThemMonHoc(string TenMonHoc)
            {
                MonHocThamGia.Add(TenMonHoc);
            }

            public void BoMonHoc(string TenMonHoc)
            {
                MonHocThamGia.Remove(TenMonHoc);
            }
        }

        private void Reset()
        {
            textBox_HoTen.Text = "";
            textBox_mssv.Text = "";
            comboBox_ChuyenNganh.SelectedIndex = -1;
            radioButton_Nam.Checked = false;
            radioButton_Nu.Checked = false;
            button2_BACK_Click(null, EventArgs.Empty);
        }

        public List<SinhVien> DSSinhVien = new List<SinhVien>();

        public class tmpSinhVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string ChuyenNganh { get; set; }
            public string GioiTinh { get; set; }
            public int SoMon { get; set; }
        }
        private void CapNhatDataGridView()
        {
            List<tmpSinhVien> DS_tmpSinhVien = new List<tmpSinhVien>();
            foreach (var SinhVien in DSSinhVien)
            {
                tmpSinhVien svien = new tmpSinhVien();
                svien.MSSV = SinhVien.MSSV;
                svien.HoTen = SinhVien.HoTen;
                svien.ChuyenNganh = SinhVien.ChuyenNganh;
                svien.GioiTinh = SinhVien.GioiTinh;
                svien.SoMon = SinhVien.MonHocThamGia.Count;
                DS_tmpSinhVien.Add(svien);
            }
            dataGridView.DataSource = DS_tmpSinhVien;
        }
        private void button_LuuThongTin_Click(object sender, EventArgs e)
        {
            string MSSV = textBox_mssv.Text;
            foreach (SinhVien TimSinhVien in DSSinhVien)
            {
                if (TimSinhVien.MSSV == MSSV)
                {
                    TimSinhVien.HoTen = textBox_HoTen.Text;
                    TimSinhVien.ChuyenNganh = comboBox_ChuyenNganh.Text;
                    if (radioButton_Nam.Checked)
                        TimSinhVien.GioiTinh = "Nam";
                    else
                        TimSinhVien.GioiTinh = "Nu";
                    TimSinhVien.MonHocThamGia = listView_RES_MonHocThamGia.Items.Cast<ListViewItem>()
                                .Select(item => item.Text)
                                .ToList();
                    Reset();
                    CapNhatDataGridView();
                    return;
                }
            }
            string HoTen = textBox_HoTen.Text;
            string ChuyenNganh = comboBox_ChuyenNganh.Text;
            string GioiTinh = "";
            if (radioButton_Nu.Checked)
                GioiTinh = "Nu";
            else if (radioButton_Nam.Checked)
            {
                GioiTinh = "Nam";
            }
            if (MSSV == "")
            {
                MessageBox.Show("Vui lòng điền mã số sinh viên");
                return;
            }
            if (HoTen == "")
            {
                MessageBox.Show("Vui lòng điền họ tên");
                return;
            }
            if (ChuyenNganh == "")
            {
                MessageBox.Show("Vui lòng điền chuyên ngành");
                return;
            }
            if (GioiTinh == "")
            {
                MessageBox.Show("Vui lòng điền giới tính");
                return;
            }

            SinhVien svien = new SinhVien();
            svien.MSSV = MSSV;
            svien.HoTen = HoTen;
            svien.ChuyenNganh = ChuyenNganh;
            svien.GioiTinh = GioiTinh;
            svien.MonHocThamGia = listView_RES_MonHocThamGia.Items.Cast<ListViewItem>()
                                .Select(item => item.Text)
                                .ToList();
            dataGridView.RowEnter -= RowEnterDataGridView;
            DSSinhVien.Add(svien);
            Reset();
            CapNhatDataGridView();
            dataGridView.RowEnter += RowEnterDataGridView;
        }

        private void button1_TO_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem MonHocDangChon in listView_MonHocThamGia.SelectedItems)
            {
                listView_MonHocThamGia.Items.Remove(MonHocDangChon);
                listView_RES_MonHocThamGia.Items.Add(MonHocDangChon);
            }
        }

        private void button2_BACK_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem MonHocDangChon in listView_RES_MonHocThamGia.SelectedItems)
            {
                listView_RES_MonHocThamGia.Items.Remove(MonHocDangChon);
                listView_MonHocThamGia.Items.Add(MonHocDangChon);
            }
        }

        private void button_XoaChon_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count >= 1)
            {
                
                for (int i = dataGridView.SelectedRows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[i];
                    string mssv = row.Cells["Column_MSSV"].Value?.ToString() ?? string.Empty;
                    SinhVien svienxoa = new SinhVien();
                    foreach (var svien in DSSinhVien)
                        if (mssv == svien.MSSV)
                        {
                            svienxoa = svien;
                            break;
                        }
                    DSSinhVien.Remove(svienxoa);
                }    
                
                Reset();
                CapNhatDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void RowEnterDataGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow DongDangChon = dataGridView.Rows[e.RowIndex];
            string mssv = DongDangChon.Cells["Column_MSSV"].Value?.ToString() ?? string.Empty;

            SinhVien svien_Chon = new SinhVien();
            foreach (var svien in DSSinhVien)
                if (mssv == svien.MSSV)
                {
                    svien_Chon = svien;
                    break;
                }

            textBox_mssv.Text = mssv;
            textBox_HoTen.Text = svien_Chon.HoTen;
            comboBox_ChuyenNganh.Text = svien_Chon.ChuyenNganh;
            if (svien_Chon.GioiTinh == "Nam")
                radioButton_Nam.Checked = true;
            else
                radioButton_Nu.Checked = true;
            foreach (var MonHoc in svien_Chon.MonHocThamGia)
            {
                var MonHocXoa = listView_MonHocThamGia.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Text == MonHoc);
                if (MonHocXoa != null)
                {
                    listView_MonHocThamGia.Items.Remove(MonHocXoa);
                    listView_RES_MonHocThamGia.Items.Add((ListViewItem)MonHocXoa);
                }
            }
        }
    }
}