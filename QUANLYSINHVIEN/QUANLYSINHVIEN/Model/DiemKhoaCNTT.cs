using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Model
{
    public class DiemKhoaCNTT
    {
        [Key]
        public string IDdiem { get; set; }
        public int diemPascal { get; set; }
        public int diemC { get; set; }
        public int diemSQL { get; set; }
        public string idSinhVien { get; set; }
        [ForeignKey("idSinhVien")]
        public SinhVien ID { get; set; }
       
    }
}
