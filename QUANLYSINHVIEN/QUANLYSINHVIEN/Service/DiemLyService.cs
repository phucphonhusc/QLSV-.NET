using QUANLYSINHVIEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Service
{
    class DiemLyService
    {
        public static DiemKhoaVatLy GetDiemLyDB(String idsv)
        {
            var db = new QLSVContext();
            return db.DiemKhoaVatLys.Where(e => e.idSinhVien == idsv).FirstOrDefault();
        }
    }
}
