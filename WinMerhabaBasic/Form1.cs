﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMerhabaBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;
            string soyisim = txtSoyisim.Text;
            DateTime dateTime = DateTime.Now;

            MessageBox.Show("Merhaba " + isim + " " + soyisim + " " + "Bugün " + dateTime);
        }
    }
}
