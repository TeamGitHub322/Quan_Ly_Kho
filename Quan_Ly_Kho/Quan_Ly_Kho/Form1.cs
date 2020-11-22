using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void butQuanLyKho_Click(object sender, EventArgs e)
          {
               frmQuanLyKho frm = new frmQuanLyKho();
               frm.ShowDialog();
               frm.Close();
               frm.Dispose();
          }

          private void butHuongDan_Click(object sender, EventArgs e)
          {
               HuongDan.Help frm = new HuongDan.Help();
               frm.ShowDialog();
               frm.Close();
               frm.Dispose();
          }
     }
}
