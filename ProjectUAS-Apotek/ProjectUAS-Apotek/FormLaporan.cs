﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUAS_Apotek
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {

        }

        private void buttonLihat_Click(object sender, EventArgs e)
        {
            FormLaporanDetail frmLaporanDetail = new FormLaporanDetail();
            frmLaporanDetail.Show();
        }
    }
}
