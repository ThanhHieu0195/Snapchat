﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapChat
{
    public partial class frmDangNhap : Form
    {
        #region varible
        ViewLayer vl;
        #endregion
        public frmDangNhap()
        {
            InitializeComponent();
            vl = new ViewLayer();
        }

        #region event
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            vl.clickDangNhap(txtuser, txtpass);
        }
        #endregion

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            //vl.clickDangKi(txtuser, txtpass);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
       
    }
}