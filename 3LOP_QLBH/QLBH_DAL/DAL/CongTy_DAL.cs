using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBH_DAL
{
   public class CongTy_DAL
    {
        ThaoTacCSDL thaotac = new ThaoTacCSDL();
        string[] name = { };
        object[] value = { };
        public DataTable CongTy_Select()
        {
            return thaotac.SQL_Laydulieu("select_CONGTY");
        }

        public DataTable CongTy_Select_Where(string MaCty)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MACTY"; value[0] = MaCty;
            return thaotac.SQL_LayDuLieu_CoDK("Select_Where_CONGTY", name, value, 1);
        }
        public int CongTy_Insert(string MaCty, string TenCty, string SDT, string FAX, string MSTCTY)
        {
            //thaotac.KetnoiCSDL();
            name = new string[5];
            value = new object[5];
            name[0] = "@MACTY"; value[0] = MaCty;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenCTY"; value[1] = TenCty;
            name[2] = "@SDT"; value[2] = SDT;
            name[3] = "@FAX"; value[3] = FAX;
            name[4] = "@MSTCTY"; value[4] = MSTCTY;

            return thaotac.SQL_Thuchien("Insert_CONGTY", name, value, 5);
        }


        public int CongTy_Update(string MaCty, string TenCty, string SDT, string FAX, string MSTCTY)
        {
            //thaotac.KetnoiCSDL();
            name = new string[5];
            value = new object[5];
            name[0] = "@MACTY"; value[0] = MaCty;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenCTY"; value[1] = TenCty;
            name[2] = "@SDT"; value[2] = SDT;
            name[3] = "@FAX"; value[3] = FAX;
            name[4] = "@MSTCTY"; value[4] = MSTCTY;

            return thaotac.SQL_Thuchien("Update_CONGTY", name, value, 5);
        }
        public int CongTy_Delete(string MaCty)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MACTY"; value[0] = MaCty;
            return thaotac.SQL_Thuchien("Delete_CONGTY", name, value, 1);
        }
    }
}
