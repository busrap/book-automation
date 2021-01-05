using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapOtomasyon_odev
{
    public partial class Form1 : Form
    {
        //Bu kodların tamamı öğrenci yıllarımda yazılmıştır ve gayet acemidir:))
        public Form1()
        {
            InitializeComponent();
        }

        class KitapVeYazar
        {
            public string YazarAdi { get; set; }
            public string YazarSoyadi { get; set; }
            public string KitapAdi { get; set; }
            public string KitapTuru { get; set; }

        }
        int index;
        KitapVeYazar  KitapVeYazarBilgileriYeniKayit(KitapVeYazar bilgiler)
        {

            bilgiler.KitapAdi = txt_kitapAdi.Text;
            bilgiler.KitapTuru = txt_kitapTuru.Text;
            bilgiler.YazarAdi = txt_yazarAdi.Text;
            bilgiler.YazarSoyadi = txt_yazarSoyadi.Text;

            return bilgiler;

        }
        public void BtnEnabled(bool etkin)
        {
            btn_birOncekiKayit.Enabled = etkin;
            btn_birSonrakiKayit.Enabled = etkin;
            btn_EnBasaDon.Enabled = etkin;
            btn_EnSonEklenen.Enabled = etkin;
            btn_sil.Enabled = etkin;
        }
        public void temizle()
        {

            txt_kitapAdi.Text = "";
            txt_kitapTuru.Text = "";
            txt_yazarAdi.Text = "";
            txt_yazarSoyadi.Text = "";
        }
        public void temizleLbl()
        {
            lbl_kitapAdi.Text = "-";
            lbl_kitapTuru.Text = "-";
            lbl_yazarAdi.Text = "-";
            lbl_yazarSoyadi.Text = "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temizleLbl();
            BtnEnabled(false);
        }

        List<KitapVeYazar> liste = new List<KitapVeYazar>();
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            KitapVeYazar kitap = new KitapVeYazar();
            KitapVeYazarBilgileriYeniKayit(kitap);
            liste.Add(kitap);
            temizle();


        }
        bool varmi = false;
        private void btn_kayitAra_Click(object sender, EventArgs e)
        {
            if (lbl_kitapAdi.Text != string.Empty)
            {
                BtnEnabled(true);
            }
            foreach (KitapVeYazar item in liste)
            {
                if (txt_kayitAra.Text==item.KitapAdi)
                {
                    lbl_kitapAdi.Text = item.KitapAdi;
                    lbl_kitapTuru.Text = item.KitapTuru;
                    lbl_yazarAdi.Text = item.YazarAdi;
                    lbl_yazarSoyadi.Text = item.YazarSoyadi;

                    txt_kayitAra.Text = "";
                    varmi = true;

                    break;
                }
                index++;
             
            }
            if (varmi == false)
            {
                MessageBox.Show("''" + txt_kayitAra.Text + "''" + " adlı kitap kaydı bulunmamaktadır!");
                txt_kayitAra.Text = "";
                temizleLbl();
            }
            varmi = false;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {


            int say = -1;
            foreach (KitapVeYazar item in liste)
            {

                if (lbl_kitapAdi.Text == item.KitapAdi)
                {
                    if (say == -1) //ilk elemanın silinmesi durumunda çalışacak kod.
                    {
                        say++;

                        liste.Remove(item);
                        lbl_kitapAdi.Text = liste[say].KitapAdi;
                        lbl_kitapTuru.Text = liste[say].KitapTuru;
                        lbl_yazarAdi.Text = liste[say].YazarAdi;
                        lbl_yazarSoyadi.Text = liste[say].YazarSoyadi;
                        temizleLbl();

                        break;
                    }
                    liste.Remove(item);//listede görüntülenen elemanı silelim
                    lbl_kitapAdi.Text = liste[say].KitapAdi;// say değişkeni ile silinen item dan bir önceki liste elemanının index sayısı belirlendi
                    lbl_kitapTuru.Text = liste[say].KitapTuru;
                    lbl_yazarAdi.Text = liste[say].YazarAdi;
                    lbl_yazarSoyadi.Text = liste[say].YazarSoyadi;

                    break;

                }
                say++;//döngü döndükçe -1 olan değer bize silinen değerin her zaman 1 eksik index sayısını verecek 3. eleman silindiyse say'ın degeri 2 olacak ve 2 değeri ile bir önceki list elemanlarını çağırıp labellerde yazdıra bileceğiz.

            }
            index = say;// ileri geri butonları için ekranda yazdırılan list elemanının kaçıncı sırada olduğu index değişkenine atandı 
        }

        private void btn_EnBasaDon_Click(object sender, EventArgs e)
        {

            index = 0;
            Stack ilkEklenen = new Stack();

            foreach (KitapVeYazar item in liste)//list'de ki tüm elemanları döngü ile stack'in içine attık
            {
                ilkEklenen.Push(item);//stack'e elemanlar ekleniyor
            }

            foreach (KitapVeYazar item in ilkEklenen)//tüm list elemanları stack'in içerisinde stack'e göre ilk giren ilk çıkar mantığı bize listemizin daima ilk elemanını verecek. 
            {
                lbl_kitapAdi.Text = item.KitapAdi;
                lbl_kitapTuru.Text = item.KitapTuru;
                lbl_yazarAdi.Text = item.YazarAdi;
                lbl_yazarSoyadi.Text = item.YazarSoyadi;
            }

        }

        private void btn_EnSonEklenen_Click(object sender, EventArgs e)
        {

            index = liste.Count - 1;
            Queue sonEklenen = new Queue();
            
            foreach (KitapVeYazar item in liste)//son giren ilk çıkar mantığı
            {
                sonEklenen.Enqueue(item);//Queue listin elemanlarını bir bir ekledik
            }
            foreach (KitapVeYazar item in sonEklenen)
            {
                lbl_kitapAdi.Text = item.KitapAdi;
                lbl_kitapTuru.Text = item.KitapTuru;//son kayıt label'lara yazdırılıyor..
                lbl_yazarAdi.Text = item.YazarAdi;
                lbl_yazarSoyadi.Text = item.YazarSoyadi;

            }
        }


        private void btn_birOncekiKayit_Click(object sender, EventArgs e)
        {
          
            if (index > 0)//index'in değeri diğer butonlarda artırıldı veya azaltldı sil buttondan herzaman 1 eksi index sayısı glecek,en basa dön butondan 0 index saysı gelecek,
                index--;
            else
                index = 0;

            lbl_kitapAdi.Text = liste[index].KitapAdi;
            lbl_kitapTuru.Text = liste[index].KitapTuru;
            lbl_yazarAdi.Text = liste[index].YazarAdi;
            lbl_yazarSoyadi.Text = liste[index].YazarSoyadi;

        }

        private void btn_birSonrakiKayit_Click(object sender, EventArgs e)
        {

            if (index < liste.Count - 1)
                index++;
            else
                index = liste.Count - 1;

            lbl_kitapAdi.Text = liste[index].KitapAdi;
            lbl_kitapTuru.Text = liste[index].KitapTuru;
            lbl_yazarAdi.Text = liste[index].YazarAdi;
            lbl_yazarSoyadi.Text = liste[index].YazarSoyadi;

        }
    }
}
