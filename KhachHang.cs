using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HaiNH_CSharp1_BaiTap2
{
    class KhachHang
    {
        // Các thuộc tính
        public string ten;
        public int tuoi;
        private string diaChi;
        private string soDienThoai;
        private ArrayList arrLstDoDac;

        public KhachHang()
        {
            arrLstDoDac = new ArrayList();
        }

        public KhachHang(string ten, int tuoi, string diaChi, string soDienThoai)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            arrLstDoDac = new ArrayList();
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public ArrayList ArrLstDoDac { get => arrLstDoDac; set => arrLstDoDac = value; }

        // Phương thức thêm đồ đạc vào danh sách
        public void NhapDoDac()
        {
            int loai;
            do
            {
                Console.Write("Nhập loại đồ đạc (1: Máy tính, 2: Bàn, 3: Ghế, 4: Tủ đồ, 5: Giường, 0:Thoát): ");
                loai = Convert.ToInt32(Console.ReadLine());
                switch (loai)
                {
                    case 1:
                        MayTinh mt = new MayTinh();
                        Console.WriteLine("Nhập chiều dài: ");
                        mt.ChieuDai = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng: ");
                        mt.ChieuRong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều sâu: ");
                        mt.ChieuSau = Convert.ToDouble(Console.ReadLine());
                        arrLstDoDac.Add(mt);
                        break;
                    case 2:
                        Ban ban = new Ban();
                        Console.WriteLine("Nhập chiều dài: ");
                        ban.ChieuDai = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng: ");
                        ban.ChieuRong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều sâu: ");
                        ban.ChieuSau = Convert.ToDouble(Console.ReadLine());
                        arrLstDoDac.Add(ban);
                        break;
                    case 3:
                        Ghe ghe = new Ghe();
                        Console.WriteLine("Nhập chiều dài: ");
                        ghe.ChieuDai = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng: ");
                        ghe.ChieuRong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều sâu: ");
                        ghe.ChieuSau = Convert.ToDouble(Console.ReadLine());
                        arrLstDoDac.Add(ghe);
                        break;
                    case 4:
                        TuDo tu = new TuDo();
                        Console.WriteLine("Nhập chiều dài: ");
                        tu.ChieuDai = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng: ");
                        tu.ChieuRong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều sâu: ");
                        tu.ChieuSau = Convert.ToDouble(Console.ReadLine());
                        arrLstDoDac.Add(tu);
                        break;
                    case 5:
                        Giuong giuong = new Giuong();
                        Console.WriteLine("Nhập chiều dài: ");
                        giuong.ChieuDai = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều rộng: ");
                        giuong.ChieuRong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhập chiều sâu: ");
                        giuong.ChieuSau = Convert.ToDouble(Console.ReadLine());
                        arrLstDoDac.Add(giuong);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Loại đồ đạc không hợp lệ!");
                        return;
                }
            } while (loai != 0);
            
        }

        public void BotDoDac()
        {
            // In danh sách đồ đạc và vị trí của chúng
            Console.WriteLine("Danh sách đồ đạc:");
            for (int i = 0; i < arrLstDoDac.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, arrLstDoDac[i]);
            }

            // Yêu cầu người dùng nhập vào vị trí muốn xóa
            Console.Write("Nhập vị trí của đồ đạc cần xóa: ");
            int viTri = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra vị trí có hợp lệ hay không, nếu không thì in ra thông báo, nếu có thì xóa đồ đạc tại vị trí đó
            if (viTri < 0 || viTri >= arrLstDoDac.Count)
            {
                Console.WriteLine("Vị trí không hợp lệ!");
            }
            else
            {
                arrLstDoDac.RemoveAt(viTri); ;
            }
        }
        // Lớp khách hàng có phương thức InRa_ThongTinKH (public)
        public void InRa_ThongTinKH()
        {
            Console.WriteLine($"Tên khách hàng: {ten} | Tuổi: {tuoi} | Địa chỉ: {diaChi} | Số điện thoại: {soDienThoai}");
            Console.WriteLine($"Danh sách đồ đạc: ");
            Console.WriteLine($"Số phần tử: {arrLstDoDac.Count}");
            foreach (DoDac item in arrLstDoDac)
            {
                item.InraThongTin();
            }
        }
        // Tính tổng thể tích từng khách hàng
        public double TongTheTich()
        {
            double tong = 0;
            foreach (DoDac item in arrLstDoDac)
            {
                tong += item.TinhTheTich();
            }
            return tong;
        }
    }
}
