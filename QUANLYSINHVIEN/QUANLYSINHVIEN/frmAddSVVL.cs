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
    public partial class frmAddSVVL : Form
    {
        SinhVien sv;
        public frmAddSVVL()
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
            //bool gioitinh = txtgioitinh.Checked =  GENDER.Male;
            //SinhVienService.AddSVVLDB(hoten, ngaysinh, gioitinh);
            //var gioitinh = txtgioitinh.Checked = ( Model.GENDER.Male);
            SinhVienService.AddSVVLDB(hoten, ngaysinh,GENDER.Male);
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
        }
    }
}
