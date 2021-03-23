using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH_DAL
{
    public class HangHoa_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable HangHoa_Select()
        {
            return thaotac.SQL_Laydulieu("Select_HANGHOA");
        }

        public DataTable HangHoa_Select_Where(string MaHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MAHH"; value[0] = MaHang;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Where_HANGHOA", name, value, 1);
        }
        public int HangHoa_Insert(string MaHang, string TenHang, string DVT, float DonGia)
        {
            //thaotac.KetnoiCSDL();
            name = new string[4];
            value = new object[4];
            name[0] = "@MAHH"; value[0] = MaHang;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenHH"; value[1] = TenHang;
            name[2] = "@DVT"; value[2] = DVT;
            name[3] = "@Dongia"; value[3] = DonGia;
            return thaotac.SQL_Thuchien("Insert_HANGHOA", name, value, 4);
        }


        public int HangHoa_Update(string MaHang, string TenHang, string DVT, float DonGia)
        {
            //thaotac.KetnoiCSDL();
            name = new string[4];
            value = new object[4];
            name[0] = "@MAHH"; value[0] = MaHang;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenHH"; value[1] = TenHang;
            name[2] = "@DVT"; value[2] = DVT;
            name[3] = "@Dongia"; value[3] = DonGia;
            return thaotac.SQL_Thuchien("Update_HANGHOA", name, value, 4);
        }
        public int HangHoa_Delete(string MaHang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MAHH"; value[0] = MaHang;
            return thaotac.SQL_Thuchien("Delete_HANGHOA", name, value, 1);
        }
    }
    
}
