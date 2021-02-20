using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string deger1 = textbox4.Text;
            //burada textbox4 deki değeri aldım 
            int dogum_yili = Int32.Parse(deger1);
            //string i int e dönüştürdüm.
            int yas = 0;
            for (yas = 0; yas + dogum_yili < 2020; yas++) ;
            this.textBox5.Text = yas.ToString();
            //bu döngüyü de çıkarma işlemi yapmayın dediğiniz için yazdım 2020 ye gelinceye kadar yas a ekledi 
            //bir altında ki satırda da çıkan sonucu textbox5 e yazdırdı.
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adsoyad = "";
            adsoyad = textbox1.Text + " " +textbox2.Text;
            //burada isim soyisim birleşik yazmak için bir string e atadım adsoyad adında 
            string harf1 = textBox5.Text.Substring(0, 1);
            //burada ilk harfi aldım 
            int rakam1 = Int32.Parse(harf1);
            //int e çevirdim
            string harf2 = textBox5.Text.Substring(1, 1);
            //2. harfi aldım 
            int rakam2 = Int32.Parse(harf2);
            //int e çevirdim
            int toplam = rakam1 + rakam2;
            //toplam adında bir int e ilk 2 rakamı ekledim
            for(int i = 1; i <= toplam; i++)
            {
                listBox1.Items.Add(adsoyad);
            }
            //son olarak for döngüsünde toplam a kadar ad soyad ekledim 
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sayi1 = textbox3.Text;
            //textbox3 deki değeri sayi1 değişkenine atadım.
            string ilkdort = sayi1.Substring(0, 4);
            //sayi1 deki ilk 4 rakamı ilkdort değişkenine atadım.
            int ilkdortlu = Int32.Parse(ilkdort);
            //sonra bunu int e çevirdim.
            string sondort = sayi1.Substring(5, 4);
            //sayi1 deki son 4 rakamı sondort değişkenine atadım.
            int sondortlu = Int32.Parse(sondort);
            //sonra int e çevirdik.
            int kucuk, buyuk = 0;
            //kucuk ve buyuk diye 2 int değişken tanımladım.
            
            if (ilkdortlu < sondortlu)
            {
                kucuk = ilkdortlu;
                buyuk = sondortlu;
            }
            else  {
                kucuk = sondortlu;
                buyuk = ilkdortlu;
            }
            //if koşuluna sokup ilkdortlu nün mü sondortlu nün mü büyük olduğunu buldum.
            
            int kalan1 = kucuk % 100;
            //bu kısımda kucuk sayının 100 e bölümünden kalanı buldum.
            
            int ilksayi = kucuk + 100 - kalan1;
            // aralıkda ki ilk 100 e tam bölünen sayıyı buldum.

            string satir = "";
            //satir adında bir değişken tanımladım.
            for(int i = ilksayi; i < buyuk; i = i + 100)
            {
                
                if (ilksayi % 1000 == i % 1000 && i!=ilksayi)
                {
                    satir = satir + Environment.NewLine;

                }
                
                satir = satir + " " + i.ToString();
               
            }
            //for döngüsünde ilk sayi buyuk sayıya gelinceye kadar 100 er 100 er ekleme yaptım.
            //içinde ki if koşulunda her 10 satırda bir alt satıra geçmesini sağladım.
            //&& bu koşulla da ilk başta eşitken altsatıra geçmemesi için yazdım.
         
            richTextBox1.Text = satir;
            //son olarak da richtextbox a yazdırdım.
        }

    }
}
