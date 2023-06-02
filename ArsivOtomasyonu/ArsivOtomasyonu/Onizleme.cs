using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ArsivOtomasyonu
{
    public partial class Onizleme : DevExpress.XtraEditors.XtraForm
    {
        public Onizleme()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void Onizleme_Load(object sender, EventArgs e)
        {
            pdfViewer1.DocumentFilePath = @"a.pdf";
        }
    }
}