﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmThemDV : Form
    {
        string maPhieuThue;
        public frmThemDV(string ma)
        {
            InitializeComponent();
            maPhieuThue = ma;
        }

        private void icoBtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
