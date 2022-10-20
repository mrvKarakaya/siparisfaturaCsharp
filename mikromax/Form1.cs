using pentasOtoparkOtomasyon;
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

namespace mikromax
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }
        sqlConnection baglanti = new sqlConnection("Data Source=DESKTOP-F0TFDIA;Initial Catalog=mikromax;Integrated Security=True");

        public static int MusteriId { get; private set; }

        void temizle()
        {
            
            

}

        private void Form1_Load(object sender, EventArgs e)
        {
            Fonksiyon system = new Fonksiyon();

        

            DataTable dtbs = system.GetDataTable("SELECT * FROM View_1");
            dataGridView1.DataSource = dtbs;

            
            cmbmusteriad.DataSource= system.GetDataTable("Select * from Musteriler");
            cmbmusteriad.DisplayMember = "MusteriAdSoyad";
            cmbmusteriad.ValueMember = "MusteriId";


            cmburunler.DataSource = system.GetDataTable("Select * from Urunler");
            cmburunler.DisplayMember = "UrunAd";
            cmburunler.ValueMember = "UrunId";

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Visible = true;
            //listBox1.DataSource = dtbs;
            //listBox1.DisplayMember = "MusteriAd";
            //listBox1.ValueMember = "MusteriId";



        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    DataRowView dr = (DataRowView)dataGridView1.DataSource;
        //    txtMusteriAd.Text = dr["MusteriAd"].ToString();
        //    txtMusteriSoyad.Text = dr["MusteriSoyad"].ToString();
        //    txtMusteriAdres.Text = dr["MusteriAdres"].ToString();
        //    txtMusteriVergiNo.Text = dr["MusteriVergiNo"].ToString();
        //    txtUrunAd.Text = dr["UrunAd"].ToString();
        //    txtUrunStok.Text = dr["UrunStok"].ToString();
        //    txtUrunMiktar.Text = dr["UrunMiktar"].ToString();
        //    txtUrunFiyat.Text = dr["UrunFiyat"].ToString();

        //}

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fonksiyon f = new Fonksiyon();

            DataRowView musterirow=  (DataRowView)cmbmusteriad.SelectedItem;
          int musteriid= int.Parse(musterirow["MusteriId"].ToString());
            DataRowView urunrow =  (DataRowView)cmburunler.SelectedItem;
            int urunid=int.Parse(urunrow["UrunId"].ToString());

          string evrakno=  txtevrakno.Text;
            DateTime tarih = dateTimePicker1.Value;
            string zaman = tarih.ToString("yyyy-MM-dd HH:mm:ss");

            f.cmd("insert into Siparisler Values(" + evrakno + ",'" + zaman + "'," + urunid + "," + musteriid + ")");

            DataTable dtbs = f.GetDataTable("SELECT * FROM View_1");
            dataGridView1.DataSource = dtbs;


        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secim = dataGridView1.SelectedCells[0].RowIndex;
           //cmbmusteriad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            //txtMusteriAdres.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            //txtMusteriVergiNo.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.musterilerTableAdapter.Fill(this.mikromaxDataSet.musteriler);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 gitform2 = new Form2();
            int secim = int.Parse(dataGridView1.SelectedCells[9].Value.ToString());
            gitform2.Tag = secim;
            gitform2.Show();
            this.Hide();
        }

        private void txtevrakno_TextChanged(object sender, EventArgs e)
        {

        }
    }

        //private void button3_Click(object sender, EventArgs e)
        //{ 
        
        //    Fonksiyon f = new Fonksiyon();
        //    f.cmd("Update Musteriler Set MusteriAd='Mehmet' where MusteriId=" + seciliMusteriId);
        //}
    }

