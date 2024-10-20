using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//23dh114467_LeHoangNam
namespace LeHoangNam_Test02
{
    internal class DanhSachLienKet_SV
    {
        SV_Node first = null;
        SV_Node last = null;

        public DanhSachLienKet_SV()
        {
        }

        public DanhSachLienKet_SV(SV_Node first, SV_Node last)
        {
            this.First = first;
            this.Last = last;
        }

        internal SV_Node First { get => first; set => first = value; }
        internal SV_Node Last { get => last; set => last = value; }
        public bool IsEmpty()
        {
            return first == null;
        }
        //Hàm kiểm tra mã sinh viên hoặc mã khoa có bị trùng hay không
        public bool IsDuplicate(int maSo, string khoa)
        {

            SV_Node p = first;
            while (p != null)
            {
                if (p.Data.MaSo == maSo || p.Data.Khoa == khoa)
                {
                    return true;
                    p = p.Next;
                }
            }
            return false;
        }
        //Hàm thêm sinh viên vào danh sách theo thứ tự tăng dần của mã số sinh viên
        public void Insert(SinhVien sv)
        {
            //Kiểm tra mã số sinh viên hoặc mã khoa có bị trùng hay không
            if (IsDuplicate(sv.MaSo, sv.Khoa))
            {
                Console.WriteLine("Mã số sinh viên hoặc mã khoa bị trùng");
                return;
            }
            //Tạo node mới cho sinh viên
            SV_Node newNode = new SV_Node(sv);
            if (first == null || first.Data.MaSo >= newNode.Data.MaSo)
            {
                newNode.Next = first;
                first = newNode;
            }
            else
            {
                SV_Node p = first;
                while (p.Next != null && p.Next.Data.MaSo < newNode.Data.MaSo)
                {
                    p = p.Next;
                }
                //Chèn sinh viên mới vào danh sách
                newNode.Next = p.Next;
                p.Next = newNode;
            }
        }
        //Hàm xóa sinh viên theo mã số sinh viên
        public void Delete(int maSo)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            if (first.Data.MaSo == maSo)
            {
                first = first.Next;
                return;
            }
            SV_Node p = first;
            while (p.Next != null && p.Next.Data.MaSo != maSo)
            {
                p = p.Next;
            }
            if (p.Next == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên có mã số " + maSo);
                return;
            }
            p.Next = p.Next.Next; //Bỏ qua sinh viên có mã số cần xóa
        }
        //Hàm xuất danh sách sinh viên ra màn hình
        public void Xuat()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            SV_Node p = first;
            while (p != null)
            {
                p.Data.Xuat();
                p = p.Next;
            }
        }
        //Hàm tách sinh viên thành 2 danh sách theo giới tính
        public void SplitByGender(out DanhSachLienKet_SV dsNam, out DanhSachLienKet_SV dsNu)
        {
            dsNam = new DanhSachLienKet_SV();
            dsNu = new DanhSachLienKet_SV();
            SV_Node p = first;
            //Duyệt qua danh sách và phân loại sinh viên
            while (p != null)
            {
                if (p.Data.GioiTinh.ToLower() == "Nam")
                {
                    dsNam.Insert(p.Data);
                }
                else
                {
                    dsNu.Insert(p.Data);
                }
                p = p.Next;
            }
        }
    }
}
