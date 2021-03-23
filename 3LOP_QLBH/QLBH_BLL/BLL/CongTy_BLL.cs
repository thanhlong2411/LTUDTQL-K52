using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH_DAL;

namespace QLBH_BLL
{
     public class CongTy_BLL
    {
        CongTy_DAL congty_DAL = new CongTy_DAL();
        public DataTable CongTy_Select()
        {
            return congty_DAL.CongTy_Select();
        }
        public DataTable CongTy_Select_Where(string MaCty)
        {
            return congty_DAL.CongTy_Select_Where(MaCty);
        }
        public int CongTy_Insert(string MaCTy, string TenCTy, string SDT, string MSTCTy, string FAX)
        {
            return congty_DAL.CongTy_Insert(MaCTy, TenCTy, SDT, MSTCTy , FAX);
        }
        public int CongTy_Update(string MaCTy, string TenCTy, string SDT, string MSTCTy, string FAX)
        {
            return congty_DAL.CongTy_Update(MaCTy, TenCTy, SDT, MSTCTy, FAX);
        }
        public int CongTy_Delete(string MaCty)
        {
            return congty_DAL.CongTy_Delete(MaCty);
        }
    }
}
