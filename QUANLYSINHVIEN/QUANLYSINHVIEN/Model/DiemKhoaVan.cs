using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Model
{
    public class DiemKhoaVan
    {
        [Key]
        public string IDdiem { get; set; }
        public int diemVHCD { get; set; }
        public int diemVHHD { get; set; }
        public string idSinhVien { get; set; }
        [ForeignKey("idSinhVien")]
        public SinhVien ID { get; set; }
       

    }
}
