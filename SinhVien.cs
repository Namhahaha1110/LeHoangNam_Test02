using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//23dh114467_LeHoangNam
namespace LeHoangNam_Test02
{
    internal class SinhVien
    {
        public int MaSo { get; set; } //Mã sinh viên
        public string HoTen { get; set; } //Họ tên
        public int NamSinh { get; set; } //Ngày sinh
        public string GioiTinh { get; set; } //Giới tính
        public string ChuyenNganh { get; set; } //Tên chuyên ngành
        public string Khoa { get; set; } //Tên khoa

        //Hàm khới tạo
        public SinhVien(int maSo, string hoTen, int namSinh, string gioiTinh, string chuyenNganh, string khoa)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            ChuyenNganh = chuyenNganh;
            Khoa = khoa;
        }
        public SinhVien()
        {
        }
        //Nhập từng sinh viên một 
        public void Nhap()
        {
            Console.Write("Nhập mã số sinh viên: ");
            MaSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập họ tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhập chuyên ngành: ");
            ChuyenNganh = Console.ReadLine();
            Console.Write("Nhập tên khoa: ");
            Khoa = Console.ReadLine();
        }
        //Xuất thông tin sinh viên
        public void Xuat()
        {
            Console.WriteLine("Mã số sinh viên: " + MaSo);
            Console.WriteLine("Họ tên sinh viên: " + HoTen);
            Console.WriteLine("Năm sinh: " + NamSinh);
            Console.WriteLine("Giới tính: " + GioiTinh);
            Console.WriteLine("Chuyên ngành: " + ChuyenNganh);
            Console.WriteLine("Khoa: " + Khoa);
        }
    }
}
