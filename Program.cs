using System;
using LeHoangNam_Test02;

namespace LeHoangNam_Test02
{
    class Program
    {
        static int Menu()
        {
            //Menu chức năng
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Xóa sinh viên");
            Console.WriteLine("3. Xuất danh sách sinh viên");
            Console.WriteLine("4. Tách danh sách theo giới tính");
            Console.WriteLine("5. Thoát");
            
            while (true)
            {
                Console.Write("Mời bạn nhập chức năng (1-5): ");
                if (int.TryParse(Console.ReadLine(), out int chucNang) && chucNang >= 1 && chucNang <= 5)
                {
                    return chucNang;
                }
                else
                {
                    Console.WriteLine("Bạn nhập sai chức năng, mời nhập lại (1-5)...");
                }
            }
        }

        static void XuLy(DanhSachLienKet_SV objDanhSachLienKet, int chucNang)
        {
            // Thực hiện chức năng dựa trên lựa chọn của người dùng
            switch (chucNang)
            {
                case 1:
                    // Nhập thông tin sinh viên
                    Console.Write("Nhập mã số sinh viên: ");
                    int MaSo = int.Parse(Console.ReadLine());
                    Console.Write("Nhập họ tên sinh viên: ");
                    string HoTen = Console.ReadLine();
                    Console.Write("Nhập năm sinh: ");
                    int NamSinh = int.Parse(Console.ReadLine());
                    Console.Write("Nhập giới tính (Nam/Nữ): ");
                    string GioiTinh = Console.ReadLine();
                    Console.Write("Nhập chuyên ngành: ");
                    string ChuyenNganh = Console.ReadLine();
                    Console.Write("Nhập tên khoa: ");
                    string Khoa = Console.ReadLine();

                    SinhVien sv = new SinhVien(MaSo, HoTen, NamSinh, GioiTinh, ChuyenNganh, Khoa);
                    objDanhSachLienKet.Insert(sv);  // Sử dụng objDanhSachLienKet thay vì tạo mới
                    break;

                case 2:
                    // Xóa sinh viên theo mã số
                    Console.Write("Nhập mã số sinh viên cần xóa: ");
                    int maSoXoa = int.Parse(Console.ReadLine());
                    objDanhSachLienKet.Delete(maSoXoa);
                    break;

                case 3:
                    // Xuất danh sách sinh viên
                    objDanhSachLienKet.Xuat();
                    break;

                case 4:
                    // Tách danh sách sinh viên theo giới tính
                    objDanhSachLienKet.SplitByGender(out DanhSachLienKet_SV dsNam, out DanhSachLienKet_SV dsNu);
                    Console.WriteLine("Danh sách sinh viên nam:");
                    dsNam.Xuat();
                    Console.WriteLine("Danh sách sinh viên nữ:");
                    dsNu.Xuat();
                    break;

                case 5:
                    // Thoát chương trình
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            // Thiết lập mã hóa để hỗ trợ Unicode
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Tạo danh sách liên kết sinh viên
            DanhSachLienKet_SV objDanhSachLienKet = new DanhSachLienKet_SV();

            while (true)
            {
                int chucNang = Menu();
                XuLy(objDanhSachLienKet, chucNang);

                Console.WriteLine("****************");
                Console.Write("Nhấn enter để tiếp tục...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}
