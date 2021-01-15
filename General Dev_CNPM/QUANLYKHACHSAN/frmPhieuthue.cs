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

namespace QUANLYKHACHSAN
{
    public partial class frmPhieuthue : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        
        public frmPhieuthue()
        {
            InitializeComponent();
        }
        // Load grid control
        public void loadData()
        {
            var dataGrid = context.CHI_TIET_PHIEU_THUE_PHONG.ToList();
            gridControlPhieuthue.DataSource = dataGrid;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maPT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

            PHIEU_THUE_PHONG pt = context.PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong.ToLower() == maPT.ToLower());
            if (pt != null)
            {
                NHAN_VIEN nv = context.NHAN_VIEN.FirstOrDefault(p=>p.MaNhanVien == pt.MaNhanVien);
                txtNhanVienLap.Text = nv.HoTen;
                //tinh so ngay
                CHI_TIET_PHIEU_THUE_PHONG ctTP = context.CHI_TIET_PHIEU_THUE_PHONG.FirstOrDefault(p => p.MaThuePhong == pt.MaThuePhong);
                Double milTime = DateTime.Parse(ctTP.NgayTraDuKien.ToString()).Day - DateTime.Parse(ctTP.NgayNhan.ToString()).Day;
                txtSoNgay.Text = milTime.ToString() + " ngày";
            }
        }

        private void frmPhieuthue_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void iconBtnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhongMain frm = new frmDatPhongMain();
            frm.ShowDialog();
        }

        private void icoBtnThemdichvu_Click(object sender, EventArgs e)
        {
            frmThemDV frm = new frmThemDV("PT001");
            frm.ShowDialog();
        }
    }
}
