using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH_DAL
{
   public class HoaDon_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable HoaDon_Select()
        {
            return thaotac.SQL_Laydulieu("select_HOADON");
        }
        public DataTable HoaDon_SelectALL()
        {
            return thaotac.SQL_Laydulieu("HoaDon_SelectAll");
        }
        public DataTable HoaDon_SelectPROVIP()
        {
            return thaotac.SQL_Laydulieu("HOADON_SelectPROVIP");
        }



        public DataTable HoaDon_Select_Where(string SoHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SoHD"; value[0] = SoHD;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Where_HOADON", name, value, 1);
        }
        public int HoaDon_Insert(string SoHD, string MaKH, string MaNV, DateTime NgayHD, string MaCty, string HTTT)
        {
            //thaotac.KetnoiCSDL();
            name = new string[6];
            value = new object[6];
            name[0] = "@SHD"; value[0] = SoHD;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@NGAYHD"; value[1] = NgayHD;
            name[2] = "@HTTT"; value[2] = HTTT;
            name[3] = "@MAKH"; value[3] = MaKH;
            name[4] = "@MANV"; value[4] = MaNV;
            name[5] = "@MACTY"; value[5] = MaCty;

            return thaotac.SQL_Thuchien("Insert_HOADON", name, value, 6);
        }


        public int HoaDon_Update(string SoHD, string MaKH, string MaNV, DateTime NgayHD, string MaCty, string HTTT)
        {
            //thaotac.KetnoiCSDL();
            name = new string[6];
            value = new object[6];
            name[0] = "@SHD"; value[0] = SoHD;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@NGAYHD"; value[1] = NgayHD;
            name[2] = "@HTTT"; value[2] = HTTT;
            name[3] = "@MAKH"; value[3] = MaKH;
            name[4] = "@MANV"; value[4] = MaNV;
            name[5] = "@MACTY"; value[5] = MaCty;

            return thaotac.SQL_Thuchien("update_HOADON", name, value, 6);
        }
        public int HoaDon_Delete(string SoHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SoHD"; value[0] = SoHD;
            return thaotac.SQL_Thuchien("Delete_HOADON", name, value, 1);
        }

    }
}
