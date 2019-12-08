using QUANLYSINHVIEN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Service
{
    class DiemCNTTService
    {
        public static DiemKhoaCNTT GetDiemCNTTDB(String idsv)
        {
            var db = new QLSVContext();
            return db.DiemKhoaCNTTs.Where(e => e.idSinhVien == idsv).FirstOrDefault();
        }
    }
}
