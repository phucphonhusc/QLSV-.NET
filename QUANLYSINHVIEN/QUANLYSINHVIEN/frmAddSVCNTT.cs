using QUANLYSINHVIEN.Model;
using QUANLYSINHVIEN.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSINHVIEN
{
    public partial class frmAddSVCNTT : Form
    {
        SinhVien sv;
        public frmAddSVCNTT()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var hoten = txthoten.Text;
            var ngaysinh = txtngaysinh.Value;
            var giotinh = txtgioitinh.Checked == true ? GENDER.Male : GENDER.Female;
            SinhVienService.AddSVCNTTDB(hoten, ngaysinh, giotinh);
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
        }
    }
}
