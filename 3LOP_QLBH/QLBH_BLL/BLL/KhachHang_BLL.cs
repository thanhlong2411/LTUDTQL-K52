using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH_DAL;

namespace QLBH_BLL
{
    public class KhachHang_BLL
    {
        KhachHang_DAL khachhang_DAL = new KhachHang_DAL();
        public DataTable KhachHang_Select()
        {
            return khachhang_DAL.KhachHang_Select();
        }
        public DataTable KhachHang_Select_Where(string MaKH)
        {
            return khachhang_DAL.KhachHang_Select_Where(MaKH);
        }
        public int KhachHang_Insert(string MaKH, string HoVaTen, string TenCTyKH, string DiaChiKH, string MSTKH)
        {
            return khachhang_DAL.KhachHang_Insert(MaKH, HoVaTen,TenCTyKH, DiaChiKH,MSTKH);
        }
        public int KhachHang_Update(string MaKH, string HoVaTen, string TenCTyKH, string DiaChiKH, string MSTKH)
        {
            return khachhang_DAL.KhachHang_Update(MaKH, HoVaTen, TenCTyKH, DiaChiKH, MSTKH);
        }
        public int KhachHang_Delete(string MaKH)
        {
            return khachhang_DAL.KhachHang_Delete(MaKH);
        }
    }
}
