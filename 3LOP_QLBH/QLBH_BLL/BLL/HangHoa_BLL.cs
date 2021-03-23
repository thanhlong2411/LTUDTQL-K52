using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH_DAL;

namespace QLBH_BLL
{
    public class HangHoa_BLL
    {
        HangHoa_DAL hangHoa_DAL = new HangHoa_DAL();
        public DataTable HangHoa_Select()
        {
            return hangHoa_DAL.HangHoa_Select();
        }
        public DataTable HangHoa_Select_Where(string MaHang)
        {
            return hangHoa_DAL.HangHoa_Select_Where(MaHang);
        }
        public int HangHoa_Insert(string MaHang, string TenHang, string DVT, float DonGia)
        {
            return hangHoa_DAL.HangHoa_Insert(MaHang, TenHang, DVT, DonGia);
        }
        public int HangHoa_Update(string MaHang, string TenHang, string DVT, float DonGia)
        {
            return hangHoa_DAL.HangHoa_Update(MaHang, TenHang, DVT, DonGia);
        }
        public int HangHoa_Delete(string MaHang)
        {
            return hangHoa_DAL.HangHoa_Delete(MaHang);
        }


    }
    
}
