using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH_DAL
{
    public class KhachHang_DAL
    {

        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable KhachHang_Select()
        {
            return thaotac.SQL_Laydulieu("select_KHACHHANG");
        }

        public DataTable KhachHang_Select_Where(string MaKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MAKH"; value[0] = MaKH;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Where_KHACHHANG", name, value, 1);
        }
        public int KhachHang_Insert(string MaKH, string HoVaTen, string TenCTyKH, string DiaChiKH,string MSTKH)
        {
            //thaotac.KetnoiCSDL();
            name = new string[5];
            value = new object[5];
            name[0] = "@MAKH"; value[0] = MaKH;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@HOTENKH"; value[1] = HoVaTen;
            name[2] = "@TENCTYKH"; value[2] = TenCTyKH ;
            name[3] = "@DIACHIKH"; value[3] = DiaChiKH;
            name[4] = "@MSTKH"; value[4] = MSTKH;

            return thaotac.SQL_Thuchien("Insert_KHACHHANG", name, value, 5);
        }


        public int KhachHang_Update(string MaKH, string HoVaTen, string TenCTyKH, string DiaChiKH, string MSTKH)
        {
            //thaotac.KetnoiCSDL();
            name = new string[5];
            value = new object[5];
            name[0] = "@MAKH"; value[0] = MaKH;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenKH"; value[1] = HoVaTen;
            name[2] = "@TENCTYKH"; value[2] = TenCTyKH;
            name[3] = "@DIACHIKH"; value[3] = DiaChiKH;
            name[4] = "@MSTKH"; value[4] = MSTKH;

            return thaotac.SQL_Thuchien("Update_KHACHHANG", name, value, 5);
        }
        public int KhachHang_Delete(string MaKH)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MAKH"; value[0] = MaKH;
            return thaotac.SQL_Thuchien("Delete_KHACHHANG", name, value, 1);
        }
    }
}
