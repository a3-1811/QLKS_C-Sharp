using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN.Model;

namespace QUANLYKHACHSAN
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        private QLKS_DB context = new QLKS_DB();
        private bool checkLogin(string username, string password)
        {
            string acc = (username + password).Replace("\'", "").Trim();
            string accData = username + context.NGUOI_DUNG.Where(p => p.TenDangNhap.Equals(username)).Select(p => p.MatKhau).FirstOrDefault();
            if (acc.Equals(accData))
                return true;
            return false;
        }

        private void icoBtnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDangnhap.Text == string.Empty || txtMatkhau.Text == string.Empty)
                    throw new Exception("Vui lòng nhập đủ thông tin đăng nhập");
                if (!checkLogin(txtDangnhap.Text, txtMatkhau.Text))
                    throw new Exception("Sai thông tin đăng nhập");
                frmMain frm = new frmMain(txtDangnhap.Text);
                frm.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icoBtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
