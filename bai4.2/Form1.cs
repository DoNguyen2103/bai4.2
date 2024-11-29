using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4._2
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Thêm dữ liệu vào DataGridView
                dgvNhanVien.Rows.Add(frm.MaNV, frm.TenNV, frm.LuongCB);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns.Add("MaNV", "Mã NV");
            dgvNhanVien.Columns.Add("TenNV", "Tên NV");
            dgvNhanVien.Columns.Add("LuongCB", "Lương CB");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                Form2 frm = new Form2
                {
                    MaNV = row.Cells["MaNV"].Value.ToString(),
                    TenNV = row.Cells["TenNV"].Value.ToString(),
                    LuongCB = row.Cells["LuongCB"].Value.ToString()
                };

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật dữ liệu
                    row.Cells["MaNV"].Value = frm.MaNV;
                    row.Cells["TenNV"].Value = frm.TenNV;
                    row.Cells["LuongCB"].Value = frm.LuongCB;
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                // Danh sách tạm để lưu các dòng được chọn
                List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                // Lưu các dòng được chọn vào danh sách tạm
                foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
                {
                    rowsToDelete.Add(row);
                }

                // Xóa từng dòng trong danh sách tạm
                foreach (DataGridViewRow row in rowsToDelete)
                {
                    dgvNhanVien.Rows.Remove(row);
                }

                MessageBox.Show("Đã xóa thành công các dòng được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hãy chọn ít nhất một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
