using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IHinhThucThanhToan iHinhThucThanhToan1 = new BitCoin("001", "Tiền hàng", 1000);

            Console.WriteLine(iHinhThucThanhToan1.GetThongTinThanhToan());

            Console.ReadLine();
        }
    }
}
