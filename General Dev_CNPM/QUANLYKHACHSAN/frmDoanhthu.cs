using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using QUANLYKHACHSAN.Model;

namespace QUANLYKHACHSAN
{
    public partial class frmDoanhthu : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDoanhthu()
        {
            InitializeComponent();
        }
        QLKS_DB context = new QLKS_DB();
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }
        private void calculator()
        {
            /*var list = context.PHIEU_THUE_PHONG.Join
                (
                 context.HOA_DON,
                 PTT=>PTT.MaThuePhong,
                 HD => HD.MaHoaDon
                )*/
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadCharProduct()
        {
            //chartControl1.DataSource = list;
            chartControl1.Series["SrChart"].ArgumentDataMember = "TENLK";
            chartControl1.Series["SrChart"].ValueDataMembers.AddRange(new string[] { "SOLUONG" });

            chartControl1.Series["SrChart"].LegendTextPattern = "{A}";
            chartControl1.Series["SrChart"].Label.TextPattern = "{V:.##}";

            PieSeriesView myView = (PieSeriesView)chartControl1.Series["SrChart"].View;
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
            DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 5;
            myView.RuntimeExploding = true;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
