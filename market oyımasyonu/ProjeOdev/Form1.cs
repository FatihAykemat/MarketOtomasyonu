using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev
{
    public partial class Form1 : Form
    {
        public Form2 form2;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            urunbox.Items.Add("Gıda");
            urunbox.Items.Add("Temizlik");
            urunbox.Items.Add("Kampanya");


            calisanVeri.View = View.Details;
            calisanVeri.FullRowSelect = true;
            calisanVeri.Columns.Add("Ad", 100);
            calisanVeri.Columns.Add("Soyad", 100);
            calisanVeri.Columns.Add("Maaş", 100);
            calisanVeri.Columns.Add("Departman", 100);
            calisanVeri.Columns.Add("Şube", 100);
            calisanVeri.Columns.Add("Adres", 100);
            calisanVeri.Columns.Add("Haftalık İzin", 100);
            calisanVeri.Columns.Add("Yıllık İzin", 100);
            calisanVeri.Columns.Add("İşe Başlama Tarihi", 100);

            stokData.View = View.Details;
            stokData.FullRowSelect = true;
            stokData.Columns.Add("Mağaza Adı", 100);
            stokData.Columns.Add("Mağaza Şube", 100);
            stokData.Columns.Add("Kategori", 100);
            stokData.Columns.Add("Ürün Adı", 100);
            stokData.Columns.Add("Stok Adeti", 100);
            stokData.Columns.Add("Satış Fiyatı", 100);

            urunView.View = View.Details;
            urunView.FullRowSelect = true;
            urunView.Columns.Add("Ürün Adı", 75);
            urunView.Columns.Add("Fiyat", 75);
            




        }


        private Magaza magaza = new Magaza();
        public Calisan calisan = new Calisan();



        private void button3_Click(object sender, EventArgs e)
        {

           string[] calisanBilgi = { adText.Text, SoyadText.Text, maasBox.Text,DepartmanBox.SelectedItem.ToString(),calisan.CalisanSube,AdresBox.SelectedItem.ToString(),izinGunu.SelectedItem.ToString(),"14 Gün",calisan.CalismaSuresi.ToString() };
            calisanVeri.Items.Add(new ListViewItem(calisanBilgi));

        }
        
        private void button4_Click(object sender, EventArgs e)
        {

            calisan.CalismaSuresi = DateTime.Now;
            calisan.Ad = adText.Text;
            calisan.SoyAd = SoyadText.Text;
            calisan.Departman = DepartmanBox.Text;
            calisan.adres.Il = AdresBox.Text;
            maasBox.Text = calisan.maas.ToString();

            if (DepartmanBox.SelectedItem == "Kasiyer")
            {
                maasBox.Text = "2500";
            }
            else if (DepartmanBox.SelectedItem == "Müdür Yardımcısı")
            {
                maasBox.Text = "3500";
            }
            else if (DepartmanBox.SelectedItem == "Müdür")
            {
                maasBox.Text = "5000";
            }
            if (calisan.adres.Il == magazaAdres.SelectedItem)
            {
                calisan.CalisanSube = magazaAdEkle.Text;
            }
            

            magaza.CalisanEkle(calisan);

        }

        private Tedarikci tedarikci = new Tedarikci();
        public Urun ürün = new Urun();
        
        private void button5_Click_1(object sender, EventArgs e)
        {
            ListViewItem ekle = new ListViewItem(listBox1.SelectedItem.ToString());
            
            if (checkBox1.Checked == true)
            {
                if (listBox1.SelectedItem == "Ekmek")
                {
                    ekle.SubItems.Add("1 TL");
                    
                }
                else if (listBox1.SelectedItem == "Su 0.5ml")
                {
                    ekle.SubItems.Add("1 TL");
                    
                }
                else if (listBox1.SelectedItem == "Şeker 5kg")
                {
                    ekle.SubItems.Add("25 TL");
                    
                }
                else if (listBox1.SelectedItem == "Çay 1kg")
                {
                    ekle.SubItems.Add("30 TL");
                    
                }
                else if (listBox1.SelectedItem == "Un 5kg")
                {
                    ekle.SubItems.Add("15 TL");
                    
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (listBox1.SelectedItem == "Deterjan")
                {
                    ekle.SubItems.Add("10 TL");
                }
                else if (listBox1.SelectedItem == "Çamaşır Suyu")
                {
                    ekle.SubItems.Add("15 TL");
                }
                else if (listBox1.SelectedItem == "Yüzey Temizleyicisi")
                {
                    ekle.SubItems.Add("20 TL");
                }
                else if (listBox1.SelectedItem == "Bulaşık Tableti")
                {
                    ekle.SubItems.Add("50 TL");
                }
            }
            else if (checkBox3.Checked == true)
            {
                if (listBox1.SelectedItem == "Ses Bombası")
                {
                    ekle.SubItems.Add("80 TL");
                }
                else if (listBox1.SelectedItem == "Tabak Seti")
                {
                    ekle.SubItems.Add("20 TL");
                }
                else if (listBox1.SelectedItem == "Plastik Kap")
                {
                    ekle.SubItems.Add("10 TL");
                }
                else if (listBox1.SelectedItem == "Pijama Takımı")
                {
                    ekle.SubItems.Add("35 TL");
                }

            }
            urunView.Items.Add(ekle);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                listBox1.Items.Add("Ekmek");
                listBox1.Items.Add("Su 0.5ml");
                listBox1.Items.Add("Şeker 5kg");
                listBox1.Items.Add("Çay 1kg");
                listBox1.Items.Add("Un 5kg");
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                listBox1.Items.Clear();
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                listBox1.Items.Add("Deterjan");
                listBox1.Items.Add("Çamaşır Suyu");
                listBox1.Items.Add("Yüzey Temizleyicisi");
                listBox1.Items.Add("Bulaşık Tableti");
                
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                listBox1.Items.Clear();
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                listBox1.Items.Add("Ses Bombası");
                listBox1.Items.Add("Tabak Seti");
                listBox1.Items.Add("Plastik Kap");
                listBox1.Items.Add("Pijama Takımı");
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                listBox1.Items.Clear();
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {

            ürün.urunKategorisi = urunbox.Text;
            ürün.urunAdi = urunAdBox.Text;
            ürün.urunAdeti = urunAdet.Value;
            ürün.urunFiyat = Convert.ToDecimal(urunFiyat.Text);
             magazaBox2.Items.Add(magazaBox.SelectedItem);
            
             MessageBox.Show(magazaBox.SelectedItem.ToString()+" marketine "+ ürün.urunAdeti + " adet " + ürün.urunAdi + " eklenmiştir");
            
           

            tedarikci.UrunEkle(ürün);


        }

        private void urunbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (urunbox.Text == "Gıda")
            {
                urunAdBox.Items.Clear();
                urunAdBox.Items.Add("Ekmek");
                urunAdBox.Items.Add("Su");
                urunAdBox.Items.Add("Şeker");
                urunAdBox.Items.Add("Çay");
                urunAdBox.Items.Add("Un");
            }
            else if (urunbox.Text == "Temizlik")
            {
                urunAdBox.Items.Clear();
                urunAdBox.Items.Add("Deterjan");
                urunAdBox.Items.Add("Çamaşır Suyu");
                urunAdBox.Items.Add("Yüzey Temizleyicisi");
                urunAdBox.Items.Add("Bulaşık Tableti");


            }
            else if (urunbox.Text == "Kampanya")
            {
                urunAdBox.Items.Clear();
                urunAdBox.Items.Add("Ses Bombası");
                urunAdBox.Items.Add("Tabak Seti");
                urunAdBox.Items.Add("Plastik Kap");
                urunAdBox.Items.Add("Pijama Takımı");


            }
        }

        private void stokGoster_Click(object sender, EventArgs e)
        {
            string[] urunBilgi = {
                magazaBox.SelectedItem.ToString(),
                magazaAdres.SelectedItem.ToString(),
                urunbox.SelectedItem.ToString(),
                urunAdBox.SelectedItem.ToString(),
                urunAdet.Value.ToString(),
                urunFiyat.Text

            };
            if (magazaBox.SelectedItem == magazaBox2.SelectedItem)
            {
                stokData.Items.Add(new ListViewItem(urunBilgi));

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(calisanVeri.SelectedItems[0].SubItems[2].Text)> Convert.ToInt16(maasBox.Text))
            {
                MessageBox.Show("MAAŞ AZALTILAMAZ !!");
            }
            else
            {
                calisanVeri.SelectedItems[0].SubItems[2].Text = maasBox.Text;
            }
            
            //Clear
            maasBox.Text = "";
        }

        private void calisanVeri_MouseClick(object sender, MouseEventArgs e)
        {
            
            maasBox.Text = calisanVeri.SelectedItems[0].SubItems[2].Text;
            terfiBox.SelectedItem = calisanVeri.SelectedItems[0].SubItems[3].Text;
            subeBox.SelectedItem = calisanVeri.SelectedItems[0].SubItems[4].Text;

        }

        private void stokGuncelle_Click(object sender, EventArgs e)
        {
            stokData.SelectedItems[0].SubItems[4].Text = stokArttır.Value.ToString();
            
        }
        public string login { get; set; }
        private void stokData_MouseClick(object sender, MouseEventArgs e)
        {
            stokArttır.Value = Convert.ToInt32(stokData.SelectedItems[0].SubItems[4].Text);
            fiyatDegistir.Text = stokData.SelectedItems[0].SubItems[5].Text;
            if (login =="müdür")
            {
                stokGuncelle.Enabled = false;
                if (stokData.SelectedItems[0].SubItems[2].Text == "Kampanya")
                {
                    fiyatGuncelle.Enabled = true;

                }
                else
                {
                    fiyatGuncelle.Enabled = false;
                }
            }
            

        }
        
        private void fiyatGuncelle_Click(object sender, EventArgs e)
        {
            DateTime indTime = DateTime.Now;
            if (Convert.ToInt16(stokData.SelectedItems[0].SubItems[5].Text) >Convert.ToInt16(fiyatDegistir.Text))
            {
                stokData.SelectedItems[0].SubItems[5].Text = fiyatDegistir.Text;
                label20.Text = "En son "+indTime.ToString()+" tarihinde indirim yaptınız";

            }
            else
            {
                stokData.SelectedItems[0].SubItems[5].Text = fiyatDegistir.Text;
   
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisanVeri.SelectedItems[0].SubItems[3].Text = terfiBox.SelectedItem.ToString();
        }

        private void subeGuncelle_Click(object sender, EventArgs e)
        {
            calisanVeri.SelectedItems[0].SubItems[4].Text = subeBox.SelectedItem.ToString();
        }

        private void magazaEkle_Click(object sender, EventArgs e)
        {
            subeBox.Items.Add(magazaAdEkle.Text);
            magazaBox.Items.Add(magazaAdEkle.Text);
            calisan.CalisanSube = magazaAdEkle.Text;
            
            

        }

        private void AdresBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AdresBox.SelectedItem =="İstanbul")
            {
                magazaAdBox.Items.Add(magazaAdEkle.Text);
            }
            else if (AdresBox.SelectedItem == "Bursa")
            {
                magazaAdBox.Items.Add(magazaAdEkle.Text);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
