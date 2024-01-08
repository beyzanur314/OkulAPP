using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void frmOgretmenKayit_Load(object sender, EventArgs e)
        {
            try
            {
                var ogrtblg = new OgretmenKaydetBL();
                bool sonuc = ogrtblg.OgretmenKaydet(new OkulApp.BLL.Ogretmen { OgretmenAd = txtOgrtmnAd.Text.Trim(), OgretmenSoyad = txtOgrtmnSoyad.Text.Trim(), OgretmenTc = txtOgrtmnTc.Text.Trim() });

                if (sonuc)
                {
                    MessageBox.Show("Öğretmen kaydedildi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Öğretmen kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
               
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOgrKayıtToSec_Click(object sender, EventArgs e)
        {
            FrmOgrSec frm = new FrmOgrSec();
            frm.FormClosed += (s, args) =>
            {
                this.Show();
                this.Close();
            };
            frm.Show();
            Hide();
        }

        private class FrmOgrSec
        {
            public Action<object, object> FormClosed { get; internal set; }

            internal void Show()
            {
                throw new NotImplementedException();
            }
        }

        private void btnOgrtmnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
    