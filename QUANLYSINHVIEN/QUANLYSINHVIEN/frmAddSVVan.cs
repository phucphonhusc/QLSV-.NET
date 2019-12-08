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
    public partial class frmAddSVVan : Form
    {
        SinhVien sv;
        public frmAddSVVan()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void frmAddSVVan_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            
           
            var hoten = txthoten.Text;
            var ngaysinh  = txtngaysinh.Value;
            //txtgioitinh.Checked = sv.Gender ==GENDER.Male;
            SinhVienService.AddSVVanDB(hoten, ngaysinh, GENDER.Male);
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtidkhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgioitinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
