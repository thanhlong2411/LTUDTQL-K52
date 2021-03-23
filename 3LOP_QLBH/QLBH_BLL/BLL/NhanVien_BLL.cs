using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH_DAL;



namespace QLBH_BLL
{
   public class NhanVien_BLL
    {
        NhanVien_DAL nhanvien_DAL = new NhanVien_DAL();
        public DataTable SinhVien_Select()
        {
            return nhanvien_DAL.NhanVien_Select();
        }
        public DataTable SinhVien_Select_Where(string MaNV)
        {
            return nhanvien_DAL.NhanVien_Select_Where(MaNV);
        }
        public int SinhVien_Insert(string MaNV, string HoVaTen)
        {
            return nhanvien_DAL.NhanVien_Insert(MaNV, HoVaTen);
        }
        public int SinhVien_Update(string MaNV, string HoVaTen)
        {
            return nhanvien_DAL.NhanVien_Update(MaNV, HoVaTen);
        }
        public int SinhVien_Delete(string MaNV)
        {
            return nhanvien_DAL.NhanVien_Delete(MaNV);
        }
    }
}
