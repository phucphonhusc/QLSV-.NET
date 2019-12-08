using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Model
{
    public class QLSVContext : DbContext
    {
        public QLSVContext() : base("Data Source=DESKTOP-8GEN06L;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa; Password=123")
        {

        }
        public DbSet<SinhVien> SinhVienS { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<DiemKhoaVan> DiemKhoaVans { get; set; }
        public DbSet<DiemKhoaCNTT> DiemKhoaCNTTs { get; set; }
        public DbSet<DiemKhoaVatLy> DiemKhoaVatLys { get; set; }
    }
}
