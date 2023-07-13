using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HaiNH_CSharp1_BaiTap2
{
    internal abstract class DoDac //Lớp trừu tượng 
    {
        // Có các thông tin về chiều dài, rộng, sâu, thể tích
        private double chieuDai;
        private double chieuRong;
        private double chieuSau;
        protected double theTich; //Thông tin được bảo mật

        public double ChieuDai
        {
            get => chieuDai;
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^[0-9\.]+$"))
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ!");
                }
                else
                {
                    chieuDai = double.Parse(value.ToString());
                }

            }
        }
        public double ChieuRong {
            get => chieuRong;
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^[0-9\.]+$"))
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ!");
                }
                else
                {
                    chieuRong = double.Parse(value.ToString());
                }

            }
        }
        public double ChieuSau {
            get => chieuSau;
            set
            {
                if (!Regex.IsMatch(value.ToString(), @"^[0-9\.]+$"))
                {
                    Console.WriteLine("Giá trị nhập vào không hợp lệ!");
                }
                else
                {
                    chieuSau = double.Parse(value.ToString());
                }

            }
        }
        public double TheTich { get => theTich; set => theTich = value; }

        public DoDac()
        {

        }

        protected DoDac(double chieuDai, double chieuRong, double chieuSau)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
            this.chieuSau = chieuSau;
            this.theTich = TinhTheTich();
        }

        public double LayTheTich() //Truy xuất giá trị thể tích của đồ đạc
        {
            return theTich;
        }

        public double TinhTheTich() // Phương thức, kiểu trả về TinhTheTich
        {
            return chieuDai * chieuRong * chieuSau;
        }

        public abstract void InraThongTin(); // lớp trừu tượng InraThongTin
    }
}
