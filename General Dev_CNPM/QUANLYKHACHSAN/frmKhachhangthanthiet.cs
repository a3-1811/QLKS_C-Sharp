using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN.Model;
using System.Data.SqlClient;

namespace QUANLYKHACHSAN
{
    public partial class frmKhachhangthanthiet : UserControl
    {
        public frmKhachhangthanthiet()
        {
            InitializeComponent();
            loadData();
        }
        QLKS_DB context = new QLKS_DB();
        private void loadData()
        {
            var constr = @"data source=desktop-inad620\SQLEXPRESS;initial catalog=QLKS;integrated security=True";

            var cmdText = "select KH.MaKhachHang, KH.TenKhachHang, KH.DienThoai, COUNT(KH.MaKhachHang) as SoLuotDen, case when COUNT(KH.MaKhachHang) >= 8 then 'KC' when COUNT(KH.MaKhachHang) >= 3 then 'Vang' else 'Bac' end as LoaiHoiVien, SUM(HD.TongTien) as TongHoaDon from KHACH_HANG KH, PHIEU_THUE_PHONG PTP, HOA_DON HD where KH.MaKhachHang = PTP.MaKhachHang And HD.MaThuePhong = PTP.MaThuePhong group by KH.MaKhachHang, KH.TenKhachHang, KH.DienThoai having COUNT(KH.MaKhachHang) >= 1";

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds, "Data");
            gridControlKhachhangthanthiet.DataSource = ds.Tables["Data"];
            

            /*
            var list = context.KHACH_HANG.Join
                (
                   context.PHIEU_THUE_PHONG,
                   KH => KH.MaKhachHang,
                   PTP => PTP.MaKhachHang,
                   (KH, PTP) => new { KH, PTP }
                ).Join
                (
                    context.HOA_DON,
                    KHPT => KHPT.PTP.MaThuePhong,
                    HD => HD.MaThuePhong,
                    (KHPT,HD) => new {KHPT,HD}
                )
                .Where(p=>p.KHPT.KH.MaKhachHang.Count() >= 3)
                .Select
                (
                    p => new
                    {
                        MaKhachHang = p.KHPT.KH.MaKhachHang,
                        TenKhachHang = p.KHPT.KH.TenKhachHang,
                        DienThoai = p.KHPT.KH.DienThoai,
                        SoLuotDen = p.KHPT.PTP.MaThuePhong.Count(),
                        LoaiHoiVien = p.KHPT.PTP.MaThuePhong.Count() >= 8 ? "KC" : p.KHPT.PTP.MaThuePhong.Count() >= 5 ? "Vàng" : "Bạc",
                        TongHoaDon = p.HD.TongTien,
                    }
                ).GroupBy(p => new { p.MaKhachHang, p.TenKhachHang, p.DienThoai})
                .ToList();*/
        }
      
    }
}
