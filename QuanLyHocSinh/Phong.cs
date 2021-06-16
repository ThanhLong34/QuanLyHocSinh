using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    class Phong
    {
        private List<IInfomation> collection = new List<IInfomation>();

        // Fields
        private string phong;

        // Properties
        public string SoPhong { get => phong; set => phong = value; }

        // Constructor
        public Phong()
        {

        }
        public Phong(string s)
        {
            phong = s;
        }

        // Methods
        /// <summary>
        /// Thêm người vào phòng
        /// </summary>
        /// <param name="obj"></param>
        public void ThemNguoiVaoPhong(string lineData)
        {
            string[] data = lineData.Trim().Split();
            if (data[0].Contains("HS"))
                collection.Add(new HocSinh(lineData));
            if (data[0].Contains("GV"))
                collection.Add(new GiaoVien(lineData));
        }
        /// <summary>
        /// Đếm số người trong phòng
        /// </summary>
        /// <returns></returns>
        public int DemSoNguoiTrongPhong()
        {
            return collection.Count;
        }
        /// <summary>
        /// Xuất thông tin 1 phòng
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
                s += item + "\n";
            return s;
        }
        /// <summary>
        /// Tìm giáo viên theo lương
        /// </summary>
        /// <param name="luong"></param>
        /// <returns></returns>
        public List<IInfomation> TimGiaoVienTheoLuong(int luong)
        {
           return collection.OfType<GiaoVien>().Where(gv => gv.Luong.Equals(luong)).ToList<IInfomation>();
        }
        /// <summary>
        /// Thêm 1 danh sách vào collection
        /// </summary>
        /// <param name="save"></param>
        public void AddRange(List<IInfomation> save)
        {
            collection.AddRange(save);
        }
        /// <summary>
        /// Tìm học sinh theo giới tính
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public List<IInfomation> TimNguoiTheoGioiTinh<T>(GT k)
        {
            return collection.Where(item => item is T && item.GioiTinh == k).ToList<IInfomation>();
        }
        /// <summary>
        /// Tìm học sinh theo lớp
        /// </summary>
        /// <param name="lop"></param>
        /// <returns></returns>
        public List<IInfomation> TimHocSinhTheoLop(string lop)
        {
            return collection.OfType<HocSinh>().Where(hs => string.Compare(hs.Lop, lop, true) == 0).ToList<IInfomation>();
        }
        /// <summary>
        /// Tính lương của giáo viên theo đánh giá
        /// </summary>
        /// <param name="danhGia"></param>
        /// <returns></returns>
        public int TinhLuongCuaGiaoVienTheoDanhGia(string danhGia)
        {
            return collection.OfType<GiaoVien>().Where(item => string.Compare(item.DanhGia, danhGia, true) == 0).Sum(item => item.Luong);
        }
        /// <summary>
        /// Tìm người theo biệt danh
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bd"></param>
        /// <returns></returns>
        public List<IInfomation> TimNguoiTheoBietDanh<T>(string bd)
        {
            return collection.Where(item => item is T && string.Compare(item.BietDanh, bd, true) == 0).ToList<IInfomation>();
        }
        /// <summary>
        /// Tìm người theo tỉnh
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tinh"></param>
        /// <returns></returns>
        public List<IInfomation> TimNguoiTheoTinh<T>(string tinh)
        {
            return collection.Where(item => item is T && string.Compare(item.Tinh, tinh, true) == 0).ToList<IInfomation>();
        }







    }
}
