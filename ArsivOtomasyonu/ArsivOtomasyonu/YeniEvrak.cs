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
    public partial class YeniEvrak : DevExpress.XtraEditors.XtraForm
    {
        public YeniEvrak()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void YeniEvrak_Load(object sender, EventArgs e)
        {
            pdfViewer1.DocumentFilePath = @"a.pdf";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void YeniEvrak_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        string selectedFilePath = "";
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Bir dosya seçin";
            openFileDialog.Filter = "Pdf Dosyası|*.pdf;*.pdf;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                pdfViewer1.DocumentFilePath = selectedFilePath;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Onizleme onizle = new Onizleme();
            onizle.pdfViewer1.DocumentFilePath = selectedFilePath;
            onizle.Show();
        }
    }
}