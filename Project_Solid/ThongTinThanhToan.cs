using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Solid
{
    abstract class ThongTinThanhToan : IHinhThucThanhToan
    {
        string maThanhToan { get; set; }
        string noiDungThanhToan { get; set; }
        double soTienThanhToan { get; set; }
        public abstract string HinhThucThanhToan();

        public ThongTinThanhToan(string _maThanhToan, string _noiDungThanhToan, double _soTienThanhToan)
        {
            maThanhToan = _maThanhToan;
            noiDungThanhToan = _noiDungThanhToan;
            soTienThanhToan = _soTienThanhToan;
        }

        public string GetThongTinThanhToan()
        {
            string noiDung = "Mã thanh toán: " + maThanhToan + "\nNội Dung thanh toán: " + noiDungThanhToan + "\nSố tiền thanh toán: " + soTienThanhToan + "\nHình thức thanh toán: " + HinhThucThanhToan();
            return noiDung;
        }
    }

}
