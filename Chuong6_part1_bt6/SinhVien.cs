using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong6_part1_bt6
{
    class SinhVien
    {
        public string MaSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLT, DiemCSDL, DiemTB;

        //Ham tao khong tham so
        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 0;
            DiemLT = DiemCSDL = DiemTB = 0;
        }

        //Ham khoi tao 5 tham so

        public SinhVien(string MaSV, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLT+DiemCSDL)/2;
        }
        public void Nhap()
        {
            Console.WriteLine("Hay nhap Ma Sinh Vien cua sinh vien: ");
            MaSV = Console.ReadLine();
            Console.WriteLine("Hay nhap Ho Ten cua sinh vien: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap Nam Sinh cua sinh vien: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap Diem Lap Trinh cua sinh vien: ");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hay nhap Diem CSDL cua sinh vien: ");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Thong tin cua Sinh Vien: \n Ho Ten: {0} \t Ma Sinh Vien: {1} \t Nam Sinh: {2}" +
                "\n Diem Lap Trinh: {3} \t Diem CSDL: {4}\n diem trung binh:{5}",
                HoTen, MaSV, NamSinh, DiemLT, DiemCSDL,DiemTB);
        }
    }
}
