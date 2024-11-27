using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Solid
{
    interface IHinhThucThanhToan
    {
        string GetThongTinThanhToan();
    }

    class CreditCard:ThongTinThanhToan
    {
        public override string HinhThucThanhToan()
        {
            return "CreditCard";
        }

        public CreditCard(string _maThanhToan, string _noiDungThanhToan, double _soTienThanhToan) : base(_maThanhToan, _noiDungThanhToan, _soTienThanhToan)
        {

        }
    }

    class PayPal : ThongTinThanhToan
    {
        public override string HinhThucThanhToan()
        {
            return "PayPal";
        }

        public PayPal(string _maThanhToan, string _noiDungThanhToan, double _soTienThanhToan) : base(_maThanhToan, _noiDungThanhToan, _soTienThanhToan)
        {

        }
    }

    class BitCoin : ThongTinThanhToan
    {
        public override string HinhThucThanhToan()
        {
            return "BitCoin";
        }

        public BitCoin(string _maThanhToan, string _noiDungThanhToan, double _soTienThanhToan) : base(_maThanhToan, _noiDungThanhToan, _soTienThanhToan)
        {

        }
    }
}
