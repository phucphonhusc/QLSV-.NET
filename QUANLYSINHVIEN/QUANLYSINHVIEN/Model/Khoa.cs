using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Model
{
    public class Khoa
    {
        [Key]
        public string idKhoa { get; set; }
        public string tenKhoa { get; set; }
    }
}
