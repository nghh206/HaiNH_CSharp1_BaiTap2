using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiNH_CSharp1_BaiTap2
{
    class CongTyChuyenDo
    {
        private string tenCongTy;
        const double theTichChoPhep = 6;
        private ArrayList arrLstKhachHang = new ArrayList();

        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }

        public static double TheTichChoPhep => theTichChoPhep;

        public ArrayList ArrLstKhachHang { get => arrLstKhachHang; set => arrLstKhachHang = value; }

        public static double TheTichChoPhep1 => theTichChoPhep;

        public CongTyChuyenDo()
        {
            arrLstKhachHang = new ArrayList();
        }
        public CongTyChuyenDo(string tenCongTy)
        {
            this.tenCongTy = tenCongTy;
            arrLstKhachHang = new ArrayList();
        }


        // Có phương thức thêm hoặc bớt khách hàng trong tập hợp khách hàng

        // Phương thức thêm khách hàng vào danh sách
        public ArrayList ThemKhachHang(KhachHang kh)
        {
            arrLstKhachHang.Add(kh);
            return arrLstKhachHang;
        }

        // Phương thức xóa khách hàng khỏi danh sách
        public void XoaKhachHang()
        {
            if (arrLstKhachHang.Count > 0)
            {
                Console.WriteLine("Thông tin khách hàng");
                int count = 0;
                int indexXoaKhachHang;
                foreach (var item in arrLstKhachHang)
                {
                    Console.WriteLine($"Khác hàng thứ: {count + 1}");
                    KhachHang kh = (KhachHang)item;
                    kh.InRa_ThongTinKH();
                }
                Console.WriteLine("Vị trí khách hàng muốn xóa: ");
                indexXoaKhachHang = Convert.ToInt32(Console.ReadLine());
                if (indexXoaKhachHang - 1 >= arrLstKhachHang.Count)
                {
                    Console.WriteLine($"Vị trí {indexXoaKhachHang} không có khách hàng");
                    return;
                }
                arrLstKhachHang.RemoveAt(indexXoaKhachHang - 1);
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("Không có khách hàng nào.");
            }

        }
        public void CheckVanChuyen()
        {
            if (arrLstKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
            }
            else
            {
                foreach (KhachHang item in arrLstKhachHang)
                {
                    double tongTheTich = item.TongTheTich();
                    if (tongTheTich <= theTichChoPhep)
                    {
                        Console.WriteLine("Đủ tiêu chuẩn để vận chuyển.");
                    }
                    else
                    {
                        Console.WriteLine("Không đủ tiêu chuẩn để vận chuyển.");
                    }
                }
            }
        }
    }
}
