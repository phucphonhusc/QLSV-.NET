using QUANLYSINHVIEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Service
{
    class DiemVanService
    {
        public static DiemKhoaVan GetDiemVanDB(String idsv)
        {
            var db = new QLSVContext();
            return db.DiemKhoaVans.Where(e => e.idSinhVien == idsv).FirstOrDefault();
        }
    }
}
