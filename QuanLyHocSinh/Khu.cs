using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyHocSinh
{
    class Khu
    {
        private List<Phong> collection = new List<Phong>();

        // Fields
        private string khu;

        // Properties
        public string MaKhu { get => khu; set => khu = value; }

        // Constructor
        public Khu()
        {

        }
        public Khu(string s)
        {
            MaKhu = s;
        }

        // Methods
        /// <summary>
        ///  Nhập dữ liệu từ file
        /// </summary>
        /// <param name="nameFile"></param>
        public void NhapDuLieuChoKhu(List<string> dsFile)
        {
            foreach (var nameFile in dsFile)
            {
                StreamReader nhap = new StreamReader(@nameFile);
                string[] sub = nameFile.Split('.');
                string[] sub2 = sub[0].Split('_');
                Phong t = new Phong(sub2[1].Trim());
                string lineData;
                while ((lineData = nhap.ReadLine()) != null)
                {
                    t.ThemNguoiVaoPhong(lineData);
                }
                collection.Add(t);
                nhap.Close();
            }
        }
        /// <summary>
        ///  Xuất danh sách của 1 khu vực
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /*string s = "\n\t=======================================================================================================\n";
            s += "\t=============================================>>> Khu " + khu + " <<<=============================================\n";
            s += "\t=======================================================================================================\n";
            s += "\t\t||".PadRight(87) + "||\n";
            s += "\t\t||".PadRight(87) + "||\n";
            s += "\t\t||".PadRight(87) + "||\n";*/
            string s = "";
            s += XuatTieuDe();
            foreach (var item in collection)
                s += item;
            s += XuatKeNgang('=');
            return s;
        }
        /// <summary>
        /// Xuất kẽ ngang
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        private string XuatKeNgang(char k)
        {
            string s = "|";
            for (int i = 0; i < 143; i++)
            {
                s += k;
            }
            return s + "|";
        }
        /// <summary>
        /// Xuất tiêu đề
        /// </summary>
        /// <returns></returns>
        private string XuatTieuDe()
        {
            string s = XuatKeNgang('=') + "\n";
            s += "|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|";
            s = string.Format(s, "MS".PadRight(5), "Phòng".PadRight(6), "Lớp".PadRight(4), "Họ tên lót".PadRight(20),
                "Tên".PadRight(12), "GT".ToString().PadRight(6), "Ns".ToString().ToString().PadRight(6),
                "Tỉnh".PadRight(12), "Sđt".PadRight(6), "Lương".ToString().PadRight(9), "ĐG".PadRight(10), "Biệt danh".PadRight(20), "MĐNH".PadRight(15));
            s += "\n" + XuatKeNgang('=') + "\n";
            return s;
        }
        public List<IInfomation> TimGiaoVienTheoLuong(int luong)
        {
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimGiaoVienTheoLuong(luong));
            return save;
        }
        public int DemSoLuongNguoiTrongKhu()
        {
            return collection.Sum(item => item.DemSoNguoiTrongPhong());
        }
        public void Add(Phong p)
        {
            collection.Add(p);
        }
        public List<IInfomation> TimNguoiTheoGioiTinh<T>(GT k)
        {
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimNguoiTheoGioiTinh<T>(k));
            return save;
        }
        public List<IInfomation> TimHocSinhTheoLop(string lop)
        {
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimHocSinhTheoLop(lop));
            return save;
        }
        public int TinhLuongCuaGiaoVienTheoDanhGia(string danhGia)
        {
            return collection.Sum(item => item.TinhLuongCuaGiaoVienTheoDanhGia(danhGia));
        }
        public List<IInfomation> TimNguoiTheoBietDanh<T>(string bd)
        {
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimNguoiTheoBietDanh<T>(bd));
            return save;
        }
        public List<IInfomation> TimNguoiTheoTinh<T>(string tinh)
        {
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimNguoiTheoTinh<T>(tinh));
            return save;
        }


    }
}
