// See https://aka.ms/new-console-template for more information
using LeHoangNam_Test02;
//23dh114467_LeHoangNam
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
            int chucNang;
            if (int.TryParse(Console.ReadLine(), out chucNang))
            {
                if (chucNang >= 1 && chucNang <= 5) return chucNang;
                Console.WriteLine("Bạn nhập sai chức năng, mời nhập lại....");

            }
            Console.WriteLine("Bạn phải nhập số nguyên");
        }
    }
    static void XuLy(DanhSachLienKet_SV objDanhSachLienKet, int chucNang)
    {
        DanhSachLienKet_SV ds = new DanhSachLienKet_SV();
        switch (chucNang)
        {
            case 1:
                //Nhập thông tin sinh viên
                Console.Write("Nhập mã số sinh viên: ");
                int MaSo = int.Parse(Console.ReadLine());
                Console.Write("Nhập họ tên sinh viên: ");
                string HoTen = Console.ReadLine();
                Console.Write("Nhập năm sinh: ");
                int NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập giới tính: ");
                string GioiTinh = Console.ReadLine();
                Console.Write("Nhập chuyên ngành: ");
                string ChuyenNganh = Console.ReadLine();
                Console.Write("Nhập tên khoa: ");
                string Khoa = Console.ReadLine();

                //Tạo đối tượng sinh viên để thêm vào danh sách
                SinhVien sv = new SinhVien(MaSo, HoTen, NamSinh, GioiTinh, ChuyenNganh, Khoa);
                ds.Insert(sv);
                break;
            case 2:
                //Xóa sinh viên theo mã số
                Console.Write("Nhập mã số sinh viên cần xóa: ");
                int maSoXoa = int.Parse(Console.ReadLine());
                ds.Delete(maSoXoa);
                break;
            case 3:
                //Xuất danh sách sinh viên
                ds.Xuat();
                break;
            case 4:
                //Tách danh sách sinh viên theo giới tính
                ds.SplitByGender(out DanhSachLienKet_SV dsNam, out DanhSachLienKet_SV dsNu);
                Console.WriteLine("Danh sách sinh viên nam:");
                dsNam.Xuat();
                Console.WriteLine("Danh sách sinh viên nữ:");
                dsNu.Xuat();
                break;
            case 5:
                //Thoát chương trình
                return;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
        static void Main(string[] args)
        {
            DanhSachLienKet_SV objDanhSachLienKet = new DanhSachLienKet_SV();
            while (true)
            {
                int chucNang = Menu();
                if (chucNang == 0) break;
                XuLy(objDanhSachLienKet, chucNang);
                Console.WriteLine("****************");
                Console.Write("Nhấn enter để tiếp tục....");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
    Console.ReadKey();
}

