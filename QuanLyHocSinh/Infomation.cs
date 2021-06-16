using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    enum GT
    {
        Nam,
        Nữ,
        Bê_đê
    }
    interface IInfomation
    {
        // Properties
        string MaSo { get; set; }
        string Phong { get; set; }
        string HoTenLot { get; set; }
        string Ten { get; set; }
        GT GioiTinh { get; set; }
        int NamSinh { get; set; }
        string Tinh { get; set; }
        string SDT { get; set; }
        string BietDanh { get; set; }
    }
}
