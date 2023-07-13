using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiNH_CSharp1_BaiTap2
{
    // Xây dựng class Tu kế thừa từ lớp doDac
    internal class TuDo : DoDac
    {
        public TuDo()
        {

        }
        public TuDo(double chieuDai, double chieuRong, double chieuSau) : base(chieuDai, chieuRong, chieuSau)
        {

        }


        // Override pt abstract InraThongTin để phù hợp với class Tu
        public override void InraThongTin()
        {
            Console.WriteLine($"Kích thước của tủ đồ(Dài x Rộng X Sâu): {ChieuDai}cm x  {ChieuRong}cm x  {ChieuSau}cm");
            Console.WriteLine($"Thể tích: ${LayTheTich()}");
        }
    }
}
