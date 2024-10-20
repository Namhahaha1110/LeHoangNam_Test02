using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//23dh114467_LeHoangNam
namespace LeHoangNam_Test02
{

    internal class SV_Node
    {
        SinhVien data;
        SV_Node next;

        public SV_Node()
        {
        }

        public SV_Node(SinhVien sv)
        {
        }

        public SV_Node(SinhVien data, SV_Node next)
        {
            this.Data = data;
            this.Next = next;
        }

        internal SinhVien Data { get => data; set => data = value; }
        internal SV_Node Next { get => next; set => next = value; }
    }
}
