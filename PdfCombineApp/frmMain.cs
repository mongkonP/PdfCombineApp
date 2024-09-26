using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfCombineApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void ShowForm(Form f) {
            // ลบฟอร์มลูกอื่นๆ ทั้งหมด
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // เพิ่มฟอร์มใหม่
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void cmdCombine_Click(object sender, EventArgs e)=> ShowForm( new frmCombine());
        private void cmdConvert_Click(object sender, EventArgs e)=>  ShowForm(new  frmConvert2PDF());
    }
}
