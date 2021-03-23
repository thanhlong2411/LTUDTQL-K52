using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH_DAL;

namespace QLBH_BLL
{
   public class HoaDon_BLL
    {
        HoaDon_DAL hoaDon_DAL = new HoaDon_DAL();
        public DataTable HoaDon_Select()
        {
            return hoaDon_DAL.HoaDon_Select();
        }
        public DataTable HoaDon_SelectALL()
        {
            return hoaDon_DAL.HoaDon_SelectALL();
        }
        public DataTable HoaDon_SelectPROVIP()
        {
            return hoaDon_DAL.HoaDon_SelectPROVIP();
        }
        public DataTable HoaDon_Select_Where(string SoHD)
        {
            return hoaDon_DAL.HoaDon_Select_Where(SoHD);
        }
        public int HoaDon_Insert(string SoHD, string MaKH, string MaNV, DateTime NgayHD, string MaCty, string HTTT)
        {
            return hoaDon_DAL.HoaDon_Insert(SoHD, MaKH, MaNV, NgayHD,MaCty,HTTT);
        }
        public int HoaDon_Update(string SoHD, string MaKH, string MaNV, DateTime NgayHD, string MaCty, string HTTT)
        {
            return hoaDon_DAL.HoaDon_Update(SoHD, MaKH, MaNV, NgayHD, MaCty, HTTT);
        }
        public int HoaDon_Delete(string SoHD)
        {
            return hoaDon_DAL.HoaDon_Delete(SoHD);
        }
    }
}
