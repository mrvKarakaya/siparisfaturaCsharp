using pentasOtoparkOtomasyon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikromax
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Fonksiyon f = new Fonksiyon();
            DataRow drsiparis= f.GetDataRow("Select * from View_1 where SiparisId="+this.Tag);
            label1.Text = drsiparis["MusteriAdSoyad"].ToString();
            label2.Text = drsiparis["UrunAd"].ToString();
            label3.Text = drsiparis["MusteriAdres"].ToString();
            label4.Text = drsiparis["UrunFiyat"].ToString();
            label5.Text = drsiparis["UrunMiktar"].ToString();
            label6.Text = drsiparis["MusteriVergiNo"].ToString();
            label7.Text = drsiparis["EvrakNo"].ToString();
            label8.Text = drsiparis["Tarih"].ToString();
        }
    }
}
