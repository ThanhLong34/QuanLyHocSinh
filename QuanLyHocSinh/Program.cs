using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    class Program
    {
        static Truong ds = new Truong();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Chương trình quản lý học sinh";
            ChayChuongTrinh();
        }
        enum Menu
        {
            ThoatChuongTrinh,
            NhapDuLieu,
            XuatKhuA,
            XuatKhuB,
            XuatToanTruong,
            TimGiaoVienCoLuong_350,
            TimHocSinhNam,
            TimHocSinhNu,
            TimHocSinhLop_2,
            TinhLuongNhungGiaoVienDanhGia_Gioi,
            TimGiaoVienCoBietDanhLa_AnhDiuDang,
            TimHocSinhTinh_LamDong,


        }
        static void XuatMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n========================== MENU ==========================");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("0.".PadLeft(5) + " Thoát chương trình!");
            Console.WriteLine("1.".PadLeft(5) + " Nhập dữ liệu");
            Console.WriteLine("2.".PadLeft(5) + " Xem danh sách học sinh và giáo viên khu A");
            Console.WriteLine("3.".PadLeft(5) + " Xem danh sách học sinh và giáo viên khu B");
            Console.WriteLine("4.".PadLeft(5) + " Xem danh sách học sinh và giáo viên toàn trường");
            Console.WriteLine("5.".PadLeft(5) + " Tìm tất cả giáo viên có lương $350");
            Console.WriteLine("6.".PadLeft(5) + " Tìm tất cả học sinh nam");
            Console.WriteLine("7.".PadLeft(5) + " Tìm tất cả học sinh nữ");
            Console.WriteLine("8.".PadLeft(5) + " Tìm tất cả học sinh đang học lớp 2");
            Console.WriteLine("9.".PadLeft(5) + " Tính lương những giáo viên được đánh giá là giỏi");
            Console.WriteLine("10.".PadLeft(5) + " Tìm giáo viên có biệt danh là \"Ánh dịu dàng\"");
            Console.WriteLine("11.".PadLeft(5) + " Tìm học sinh ở tỉnh Lâm Đồng");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n========================== END ===========================");
            Console.ResetColor();
        }
        static void ChayChuongTrinh()
        {
            while (true)
            {
                Console.Clear();
                XuatMenu();
                Console.Write(">>>Chọn chức năng: ");
                Menu menu = (Menu)int.Parse(Console.ReadLine());

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n========================== CHƯƠNG TRÌNH ĐÃ XỬ LÝ XONG ===========================");
                Console.ResetColor();
                switch (menu)
                {
                    case Menu.ThoatChuongTrinh:
                        Console.WriteLine("0.".PadLeft(5) + " Thoát chương trình!");
                        return;
                    case Menu.NhapDuLieu:
                        {
                            Console.WriteLine("1.".PadLeft(5) + " Nhập dữ liệu");
                            Console.WriteLine("Nhập dữ liệu thành công!");
                            ds.NhapDuLieuChoTruong(DanhSachFile.dsFile_KhuA, "A");
                            ds.NhapDuLieuChoTruong(DanhSachFile.dsFile_KhuB, "B");
                            Console.WriteLine(ds);
                            break;
                        }
                    case Menu.XuatKhuA:
                        {
                            Console.WriteLine("2.".PadLeft(5) + " Xem danh sách học sinh và giáo viên khu A");
                            ds.XuatDuLieuTheoKhu("A");
                            break;
                        }
                    case Menu.XuatKhuB:
                        {
                            Console.WriteLine("3.".PadLeft(5) + " Xem danh sách học sinh và giáo viên khu B");
                            ds.XuatDuLieuTheoKhu("B");
                            break;
                        }
                    case Menu.XuatToanTruong:
                        {
                            Console.WriteLine("4.".PadLeft(5) + " Xem danh sách học sinh và giáo viên toàn trường\n" + ds);
                            break;
                        }
                    case Menu.TimGiaoVienCoLuong_350:
                        {
                            Console.WriteLine("5.".PadLeft(5) + " Tìm tất cả giáo viên có lương $350");
                            Console.WriteLine(ds.TimGiaoVienTheoLuong(350));
                            break;
                        }
                    case Menu.TimHocSinhNam:
                        {
                            Console.WriteLine("6.".PadLeft(5) + " Tìm tất cả học sinh nam");
                            Console.WriteLine(ds.TimNguoiTheoGioiTinh<HocSinh>(GT.Nam));
                            break;
                        }
                    case Menu.TimHocSinhNu:
                        {
                            Console.WriteLine("7.".PadLeft(5) + " Tìm tất cả học sinh nữ");
                            Console.WriteLine(ds.TimNguoiTheoGioiTinh<HocSinh>(GT.Nữ));
                            break;
                        }
                    case Menu.TimHocSinhLop_2:
                        {
                            Console.WriteLine("8.".PadLeft(5) + " Tìm tất cả học sinh đang học lớp 2");
                            Console.WriteLine(ds.TimHocSinhTheoLop("2"));
                            break;
                        }
                    case Menu.TinhLuongNhungGiaoVienDanhGia_Gioi:
                        {
                            Console.WriteLine("9.".PadLeft(5) + " Tính lương những giáo viên được đánh giá là giỏi");
                            Console.WriteLine("Lương của các giáo viên được đánh giá là giỏi là: $" + ds.TinhLuongCuaGiaoVienTheoDanhGia("Giỏi"));
                            break;
                        }
                    case Menu.TimGiaoVienCoBietDanhLa_AnhDiuDang:
                        {
                            Console.WriteLine("10.".PadLeft(5) + " Tìm giáo viên có biệt danh là \"Ánh dịu dàng\"");
                            Console.WriteLine(ds.TimNguoiTheoBietDanh<GiaoVien>("Ánh_dịu_dàng"));
                            break;
                        }
                    case Menu.TimHocSinhTinh_LamDong:
                        {
                            Console.WriteLine("11.".PadLeft(5) + " Tìm học sinh ở tỉnh Lâm Đồng");
                            Console.WriteLine(ds.TimNguoiTheoTinh<HocSinh>("Lâm_Đồng"));
                            break;
                        }







                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter any key to back Menu...");
                Console.ReadKey();
            }
        }
    }
}
