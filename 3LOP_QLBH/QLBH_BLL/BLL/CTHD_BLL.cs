using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH_DAL;

namespace QLBH_BLL
{
    public class CTHD_BLL
    {
        CTHD_DAL cthd_DAL = new CTHD_DAL();
        public DataTable CTHD_Select()
        {
            return cthd_DAL.CTHD_Select();
        }
        public DataTable CTHD_SelectALL()
        {
            return cthd_DAL.CTHD_SelectALL();
        }
        public DataTable CTHD_SelectPROVIP()
        {
            return cthd_DAL.CTHD_SelectPROVIP();
        }
        public DataTable CTHD_Select_Where(string SoHD)
        {
            return cthd_DAL.CTHD_Select_Where(SoHD);
        }
        public int CTHD_Insert(string SoHD,string MaHangHoa, int SoLuong)
        {
            return cthd_DAL.CTHD_Insert(SoHD, SoLuong, MaHangHoa);
        }
        public int CTHD_Update(string SoHD, string MaHangHoa, int SoLuong)
        {
            return cthd_DAL.CTHD_Update(SoHD, SoLuong, MaHangHoa);
        }
        public int CTHD_Delete(string SoHD)
        {
            return cthd_DAL.CTHD_Delete(SoHD);
        }
    }
}
