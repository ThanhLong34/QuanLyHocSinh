using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    class Truong
    {
        private List<Khu> collection = new List<Khu>();

        // Methods
        public void NhapDuLieuChoTruong(List<string> dsFile, string maKhu)
        {
            Khu t = new Khu(maKhu);
            t.NhapDuLieuChoKhu(dsFile);
            collection.Add(t);
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += item + "\n\n";
            }
            return s;
        }
        public void XuatDuLieuTheoKhu(string k)
        {
            foreach (var item in collection)
                if (string.Compare(item.MaKhu, k, true) == 0)
                    Console.WriteLine(item);
        }
        public Khu TimGiaoVienTheoLuong(int luong)
        {
            Khu k = new Khu();
            Phong p = new Phong();
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimGiaoVienTheoLuong(luong));
            p.AddRange(save);
            k.Add(p);
            return k;
        }
        public Khu TimNguoiTheoGioiTinh<T>(GT t)
        {
            Khu k = new Khu();
            Phong p = new Phong();
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimNguoiTheoGioiTinh<T>(t));
            p.AddRange(save);
            k.Add(p);
            return k;
        }
        public Khu TimHocSinhTheoLop(string lop)
        {
            Khu k = new Khu();
            Phong p = new Phong();
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimHocSinhTheoLop(lop));
            p.AddRange(save);
            k.Add(p);
            return k;
        }
        public int TinhLuongCuaGiaoVienTheoDanhGia(string danhGia)
        {
            return collection.Sum(item => item.TinhLuongCuaGiaoVienTheoDanhGia(danhGia));
        }
        public Khu TimNguoiTheoBietDanh<T>(string bd)
        {
            Khu k = new Khu();
            Phong p = new Phong();
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimNguoiTheoBietDanh<T>(bd));
            p.AddRange(save);
            k.Add(p);
            return k;
        }
        public Khu TimNguoiTheoTinh<T>(string tinh)
        {
            Khu k = new Khu();
            Phong p = new Phong();
            List<IInfomation> save = new List<IInfomation>();
            foreach (var item in collection)
                save.AddRange(item.TimNguoiTheoTinh<T>(tinh));
            p.AddRange(save);
            k.Add(p);
            return k;
        }

    }
}
