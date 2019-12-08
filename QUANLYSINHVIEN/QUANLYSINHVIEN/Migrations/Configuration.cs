namespace QUANLYSINHVIEN.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QUANLYSINHVIEN.Model.QLSVContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QUANLYSINHVIEN.Model.QLSVContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.SinhVienS.AddOrUpdate(
                new Model.SinhVien
                {
                    ID = "1",
                    FullName = "Nguyen Van Phuc Phon",
                    Gender = Model.GENDER.Male,
                    DateOfBirth = new DateTime(1998, 05, 15),
                    IDKHOA = "C"
                },
                new Model.SinhVien
                {
                    ID = "4",
                    FullName = "Nguyen Van Hoang",
                    Gender = Model.GENDER.Male,
                    DateOfBirth = new DateTime(1997, 05, 15),
                    IDKHOA = "C"
                },
                new Model.SinhVien
                {
                    ID = "2",
                    FullName = "Pham Van Tuan",
                    Gender = Model.GENDER.Male,
                    DateOfBirth = new DateTime(1999, 04, 19),
                    IDKHOA = "VL"
                },
                new Model.SinhVien
                {
                    ID = "5",
                    FullName = "Nguyen Van Phuc",
                    Gender = Model.GENDER.Male,
                    DateOfBirth = new DateTime(1996, 03, 15),
                    IDKHOA = "VL"
                },
                new Model.SinhVien
                {
                    ID = "3",
                    FullName = "Tran Ngoc Anh",
                    Gender = Model.GENDER.Male,
                    DateOfBirth = new DateTime(1995, 04, 02),
                    IDKHOA = "V"
                },
                new Model.SinhVien
                {
                    ID = "6",
                    FullName = "Hoang Thi Thanh",
                    Gender = Model.GENDER.Female,
                    DateOfBirth = new DateTime(1997,04, 02),
                    IDKHOA = "V"
                }

            );
            context.Khoas.AddOrUpdate(
                new Model.Khoa
                {
                    idKhoa = "V",
                    tenKhoa = "Văn"
                },
                new Model.Khoa
                {
                    idKhoa = "C",
                    tenKhoa = "CNTT"
                },
                new Model.Khoa
                {
                    idKhoa = "VL",
                    tenKhoa = "Vật Lý"
                }

            );
            context.DiemKhoaCNTTs.AddOrUpdate(
                new Model.DiemKhoaCNTT
                {
                    IDdiem = "1",
                    diemC = 9,
                    diemPascal = 8,
                    diemSQL = 9,
                    idSinhVien = "1"

                },
                new Model.DiemKhoaCNTT
                {
                    IDdiem = "2",
                    diemC = 7,
                    diemPascal = 5,
                    diemSQL = 7,
                    idSinhVien = "4"

                }

            );
            context.DiemKhoaVatLys.AddOrUpdate(
                new Model.DiemKhoaVatLy
                {
                    IDdiem = "1",
                    diemCoHoc = 9,
                    diemQuangHoc = 8,
                    diemVLHN = 9,
                    diemDien = 10,
                    idSinhVien = "2"

                },
                new Model.DiemKhoaVatLy
                {
                    IDdiem = "2",
                    diemCoHoc = 9,
                    diemQuangHoc = 8,
                    diemVLHN = 9,
                    diemDien = 10,
                    idSinhVien = "5"

                }

            );
            context.DiemKhoaVans.AddOrUpdate(
                new Model.DiemKhoaVan
                {
                    IDdiem = "1",
                    diemVHCD = 9,
                    diemVHHD = 8,
                    idSinhVien = "3"

                },
                new Model.DiemKhoaVan
                {
                    IDdiem = "2",
                    diemVHCD = 9,
                    diemVHHD = 8,
                    idSinhVien = "6"

                }


            );
            context.SaveChanges();
        }
    }
}
