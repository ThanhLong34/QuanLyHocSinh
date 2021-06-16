using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    class HocSinh : IInfomation
    {
        // Fields
        private string maSo;
        private string phong;
        private string hoTenLot;
        private string ten;
        private GT gioiTinh;
        private int namSinh;
        private string tinh;
        private string sDT;
        private string bietDanh;
        private string lop;
        private string mucDoNguyHiem;

        // Properties
        public string MaSo { get => maSo; set => maSo = value; }
        public string Phong { get => phong; set => phong = value; }
        public string HoTenLot { get => hoTenLot; set => hoTenLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public GT GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string Tinh { get => tinh; set => tinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string BietDanh { get => bietDanh; set => bietDanh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string MucDoNguyHiem { get => mucDoNguyHiem; set => mucDoNguyHiem = value; }

        // Constructor
        public HocSinh()
        {

        }
        public HocSinh(string lineData)
        {
            string[] data = lineData.Trim().Split(' ');
            maSo = data[0].Trim();
            phong = data[1].Trim();
            lop = data[2].Trim();
            hoTenLot = data[3].Trim();
            ten = data[4].Trim();
            gioiTinh = KiemTraGioiTinh(data[5].Trim());
            namSinh = int.Parse(data[6].Trim());
            tinh = data[7].Trim();
            sDT = data[8].Trim();
            bietDanh = data[9].Trim();
            mucDoNguyHiem = data[10].Trim();
        }

        // Override
        public override string ToString()
        {
            string s = "|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|";
            return string.Format(s, maSo.PadRight(5), phong.PadRight(6), lop.PadRight(4), hoTenLot.PadRight(20),
                ten.PadRight(12), gioiTinh.ToString().PadRight(6), namSinh.ToString().ToString().PadRight(6),
                tinh.PadRight(12), sDT.PadRight(6), "".PadRight(9) + "|" + "".PadRight(10) + "|" + bietDanh.PadRight(20), mucDoNguyHiem.PadRight(15));
        }

        // Methods
        private GT KiemTraGioiTinh(string data)
        {
            if (string.Compare(data.Trim(), "Nam", true) == 0)
                return GT.Nam;
            if (string.Compare(data.Trim(), "Nữ", true) == 0)
                return GT.Nữ;
            return GT.Bê_đê;
        }
    }
}
