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
    public partial class Form1 : Form
    {
        SinhVien sv;
        public Form1(SinhVien sv=null)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.sv = sv;
            
            loadSinhVien();
            
        }
        public void loadSinhVien()
        {
            bdsSinhVien.DataSource = null;
            dtgSinhVien.AutoGenerateColumns = false;
            var lsSinhVien = SinhVienService.GetSVDB();
            if(lsSinhVien != null)
            {
                bdsSinhVien.DataSource = lsSinhVien;
            }
            else
            {
                throw new Exception("Sinh viên không tồn tại");
            }
            dtgSinhVien.DataSource = bdsSinhVien;
            
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void sVVănToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmAddSVVan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadSinhVien();

            }
        }

        private void dtgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgSinhVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtName.Text = dtgSinhVien.Rows[index].Cells["FullName"].Value.ToString();
                txtNgaySinh.Text = dtgSinhVien.Rows[index].Cells["DateOfBirth"].Value.ToString();
                checkGender.Text = dtgSinhVien.Rows[index].Cells["Gender"].Value.ToString();
                if(dtgSinhVien.Rows[index].Cells["IDKHOA"].Value.ToString()== "V")
                {
                    TabPage t1 = tabControl1.TabPages[0];
                    tabControl1.SelectTab(t1);
                    DiemKhoaVan dv = DiemVanService.GetDiemVanDB(dtgSinhVien.Rows[index].Cells["ID"].Value.ToString());
                    if(dv != null)
                    {
                        
                        txtDiemVHCD.Text = dv.diemVHCD.ToString();
                        txtDiemVHHD.Text = dv.diemVHHD.ToString();
                    }
                    
                }
                if (dtgSinhVien.Rows[index].Cells["IDKHOA"].Value.ToString() == "VL")
                {
                    
                    TabPage t1 = tabControl1.TabPages[1];
                    tabControl1.SelectTab(t1);
                    DiemKhoaVatLy dv = DiemLyService.GetDiemLyDB(dtgSinhVien.Rows[index].Cells["ID"].Value.ToString());
                    if(dv != null)
                    {
                        
                        txtDiemDien.Text = dv.diemDien.ToString();
                        txtDiemCoHoc.Text = dv.diemCoHoc.ToString();
                        txtDiemQuangHoc.Text = dv.diemQuangHoc.ToString();
                        txtDiemVLHN.Text = dv.diemVLHN.ToString();
                    }
                    

                }
                if (dtgSinhVien.Rows[index].Cells["IDKHOA"].Value.ToString() == "C")
                {
                    TabPage t1 = tabControl1.TabPages[2];
                    tabControl1.SelectTab(t1);
                    DiemKhoaCNTT dv = DiemCNTTService.GetDiemCNTTDB(dtgSinhVien.Rows[index].Cells["ID"].Value.ToString());
                    if(dv != null)
                    {
                        txtDiemSQL.Text = dv.diemSQL.ToString();
                        txtDiemC.Text = dv.diemC.ToString();
                        txtDiemPascal.Text = dv.diemSQL.ToString();
                    }
                    
                }
            }
        }

        private void btnBSVL_Click(object sender, EventArgs e)
        {
            var frm = new frmAddSVVL();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadSinhVien();

            }
        }

        private void btnBSCNTT_Click(object sender, EventArgs e)
        {
            var frm = new frmAddSVCNTT();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadSinhVien();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc là muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                var sv1 = (SinhVien)bdsSinhVien.Current;
                var idsv = sv1.ID;
                SinhVienService.DeleteSVDB(idsv);
                loadSinhVien();
                MessageBox.Show("Bạn đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }
        }
    }
}
