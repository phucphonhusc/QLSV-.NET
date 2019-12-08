using QUANLYSINHVIEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Service
{
     class SinhVienService
    {
        public static List<SinhVien> GetSVDB()
        {
            var db = new QLSVContext();
            return db.SinhVienS.Select(e => e).ToList();
        }
        public static void AddSVVanDB(string hoten, DateTime ngaysinh, GENDER gioitinh)
        {
            var db = new QLSVContext();
            var cre = db.SinhVienS.Create();
            cre.ID = Guid.NewGuid().ToString();
            cre.FullName = hoten;
            cre.DateOfBirth = ngaysinh;
            cre.Gender = gioitinh;
            cre.IDKHOA = "V";
            db.SinhVienS.Add(cre);
            db.SaveChanges();
        }
        public static void AddSVVLDB(string hoten, DateTime ngaysinh, GENDER gioitinh)
        {
            var db = new QLSVContext();
            var cre = db.SinhVienS.Create();
            cre.ID = Guid.NewGuid().ToString();
            cre.FullName = hoten;
            cre.DateOfBirth = ngaysinh;
            cre.Gender = gioitinh;
            cre.IDKHOA = "VL";
            db.SinhVienS.Add(cre);
            db.SaveChanges();
        }
        public static void AddSVCNTTDB(string hoten, DateTime ngaysinh, GENDER gioitinh)
        {
            var db = new QLSVContext();
            var cre = db.SinhVienS.Create();
            cre.ID = Guid.NewGuid().ToString();
            cre.FullName = hoten;
            cre.DateOfBirth = ngaysinh;
            cre.Gender = gioitinh;
            cre.IDKHOA = "C";
            db.SinhVienS.Add(cre);
            db.SaveChanges();
        }
        public static void DeleteSVDB(string idsv)
        {
            var db = new QLSVContext();
            var itemToRemove = db.SinhVienS.SingleOrDefault(x => x.ID.Equals(idsv));
            if (itemToRemove != null)
            {
                db.SinhVienS.Remove(itemToRemove);
                db.SaveChanges();
            }


        }
    }
}
