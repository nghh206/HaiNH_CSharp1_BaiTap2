using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiNH_CSharp1_BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            int chon;
            List<KhachHang> _lstKhachHang = new List<KhachHang>();
            List<CongTyChuyenDo> _lstCTCD = new List<CongTyChuyenDo> { };

            Console.WriteLine("Nhập tên công ty: ");
            string TenCongTy = Console.ReadLine();
            CongTyChuyenDo cT = new CongTyChuyenDo(TenCongTy);

            KhachHang kh = new KhachHang();


            do
            {
                Console.WriteLine("                    Menu                ");
                Console.WriteLine("1. Nhập thông tin khách hàng và dồ dùng.");
                Console.WriteLine("2. Xuất thông tin khách hàng và dồ dùng.");
                Console.WriteLine("3. Xóa khách hàng.");
                Console.WriteLine("4. Thêm đồ");
                Console.WriteLine("5. Xóa đồ");
                Console.WriteLine("0. Thoát.");
                Console.WriteLine("Mời bạn chọn 1 chức năng.");
                        chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Nhập vào thông tin khách hàng: ");
                        string nhapTiep;
                        do
                        {
                            KhachHang khachHang = new KhachHang();
                            Console.WriteLine("Nhập tên: ");
                            khachHang.Ten = Console.ReadLine();
                            Console.WriteLine("Nhập tuổi: ");
                            khachHang.Tuoi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nhập địa chí: ");
                            khachHang.DiaChi = Console.ReadLine();
                            Console.WriteLine("Nhập sô điện thoại: ");
                            khachHang.SoDienThoai = Console.ReadLine();
                            kh.NhapDoDac();
                            _lstKhachHang.Add(khachHang);
                            Console.WriteLine("Bạn có muốn tiếp tục nhập không?");
                            Console.WriteLine("Phím bất kỳ: Có          N:Không");
                            nhapTiep = Console.ReadLine();
                        } while (nhapTiep.ToUpper() != "N");
                        break;
                    case 2:
                        Console.WriteLine("Danh sách khách hàng: ");
                        if (_lstKhachHang.Count == 0)
                        {
                            Console.WriteLine("Danh sách trống");
                        }
                        else
                        {
                            foreach (var item in _lstKhachHang)
                            {
                                item.InRa_ThongTinKH();
                            }
                        }
                        break;
                    case 3:
                        cT.XoaKhachHang();
                        break;
                    case 4:
                        ;
                        break;
                    case 5:
                        kh.BotDoDac();
                        break;
                    case 0:
                        Console.WriteLine("Cảm ơn đã sử dụng chương trình!");
                        break;
                    default:
                        Console.WriteLine("Hãy chọn từ 0 - 5!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
