using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiNH_CSharp1_BaiTap2
{
    // Xây dựng class Ban kế thừa từ lớp doDac
    internal class Ban : DoDac
    {

        public Ban()
        {

        }

        public Ban(double chieuDai, double chieuRong, double chieuSau) : base(chieuDai, chieuRong, chieuSau)
        {

        }

        // Override pt abstract InraThongTin để phù hợp với class Ban
        public override void InraThongTin()
        {
            Console.WriteLine($"Kích thước bàn(Dài x Rộng X Sâu): {ChieuDai}cm x  {ChieuRong}cm x  {ChieuSau}cm");
            Console.WriteLine($"Thể tích: ${LayTheTich()}");
        }
    }
}
