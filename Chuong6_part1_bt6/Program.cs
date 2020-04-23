using System;

namespace Chuong6_part1_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien ds = new DanhSachSinhVien();
            ds.Nhap();
            ds.Xuat();
            ds.SapXep();
            Console.Read();
        }
    }
}
