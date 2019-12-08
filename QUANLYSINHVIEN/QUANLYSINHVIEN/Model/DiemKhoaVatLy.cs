using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Model
{
    public class DiemKhoaVatLy
    {
        [Key]
        public string IDdiem { get; set; }
        public int diemCoHoc { get; set; }
        public int diemQuangHoc { get; set; }
        public int diemDien { get; set; }
        public int diemVLHN { get; set; }
        public string idSinhVien { get; set; }
        [ForeignKey("idSinhVien")]
        public SinhVien ID { get; set; }

    }
}
