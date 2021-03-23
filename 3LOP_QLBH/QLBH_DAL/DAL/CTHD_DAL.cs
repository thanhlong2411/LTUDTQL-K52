using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH_DAL
{
     public class CTHD_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable CTHD_Select()
        {
            return thaotac.SQL_Laydulieu("select_CTHD");
        }
        public DataTable CTHD_SelectALL()
        {
            return thaotac.SQL_Laydulieu("CTHD_SelectAll");
        }

        public DataTable CTHD_SelectPROVIP()
        {
            return thaotac.SQL_Laydulieu("CTHD_SelectPROVIP");
        }


        public DataTable CTHD_Select_Where(string SoHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SoHD"; value[0] = SoHD;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Where_CTHD", name, value, 1);
        }
        public int CTHD_Insert(string SoHD, int SoLuong ,string MaHangHoa )
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@SHD"; value[0] = SoHD;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            
            name[1] = "@Soluong"; value[1] = SoLuong;
            name[2] = "@MAHH"; value[2] = MaHangHoa;

            return thaotac.SQL_Thuchien("Insert_CTHD", name, value, 3);
        }


        public int CTHD_Update(string SoHD, int SoLuong, string MaHangHoa )
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@SHD"; value[0] = SoHD;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@Soluong"; value[1] = SoLuong;
            name[2] = "@MAHH"; value[2] = MaHangHoa;

            return thaotac.SQL_Thuchien("Update_CTHD", name, value, 3);
        }
        public int CTHD_Delete(string SoHD)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@SoHD"; value[0] = SoHD;
            return thaotac.SQL_Thuchien("Delete_CTHD", name, value, 1);
        }
    }
}
