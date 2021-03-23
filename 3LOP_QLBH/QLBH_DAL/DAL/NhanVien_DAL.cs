using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH_DAL
{
   public class NhanVien_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable NhanVien_Select()
        {
            return thaotac.SQL_Laydulieu("select_NHANVIEN");
        }

        public DataTable NhanVien_Select_Where(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MANV"; value[0] = MaNV;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Where_NHANVIEN", name, value, 1);
        }
        public int NhanVien_Insert(string MaNV, string HoVaTen)
        {
            //thaotac.KetnoiCSDL();
            name = new string[2];
            value = new object[2];
            name[0] = "@MANV"; value[0] = MaNV ;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@HOTENNV"; value[1] = HoVaTen;
            return thaotac.SQL_Thuchien("Insert_NHANVIEN", name, value, 2);
        }
        public int NhanVien_Update(string MaNV, string HoVaTen)
        {
            //thaotac.KetnoiCSDL();
            name = new string[2];
            value = new object[2];
            name[0] = "@MANV"; value[0] = MaNV;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@HOTENNV"; value[1] = HoVaTen;
            return thaotac.SQL_Thuchien("Update_NHANVIEN", name, value, 2);
        }
        public int NhanVien_Delete(string MaNV)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MANV"; value[0] = MaNV;
            return thaotac.SQL_Thuchien("Delete_NHANVIEN", name, value, 1);
        }
    }
}
