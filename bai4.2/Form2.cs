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
    public partial class Form2 : Form
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = MaNV;
            txtTenNV.Text = TenNV;
            txtLuongCB.Text = LuongCB;
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            MaNV = txtMaNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;

            // Đóng form với DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
