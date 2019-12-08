using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSINHVIEN.Model
{
    public class SinhVien
    {
        [Key]
        public string ID { get; set; }
        public string FullName { get; set; }
        public GENDER Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IDKHOA { get; set; }
        [ForeignKey("IDKHOA")]
        public Khoa khoa { get; set; }
        
    }
    public enum GENDER
    {
        Male, Female, Other
    }
}
