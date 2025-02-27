using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_SayiTahminOyunu
{
    public partial class OyunForm : Form
    {
        private int sayi;

        public OyunForm()
        {
            InitializeComponent();
        }

        private void l_Click(object sender, EventArgs e)
        {

        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();

            if (frm.GetName(out string userName))
            {
                lblKullanici.Text = "Hoşgeldin " + userName;
                panel1.Visible = true;
                btnTahminEt.Enabled = true; // buton aktif
            }
            else
            {
                MessageBox.Show("Kullanıcı adı boş olamaz.");
            }

            Random rnd = new Random();
            sayi = rnd.Next(1, 100);
            lblBilgi.Text = "1 ile 100 arasında bir sayı tahmin edin";

            prgBarBilgi.Value = 0; // progress barı sıfırla
            timer1.Start();

        }

        private void OyunForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            btnTahminEt.Enabled = false;

            prgBarBilgi.Maximum = 60; // progress barın maksimum değeri 60 saniyeden dolayı böyle


        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtTahmin.Text, out int cevap))
            {

                if (sayi > cevap)
                {
                    lblMesaj.Text = "Daha yüksek bir sayı deneyin";
                }
                else if (sayi < cevap)
                {
                    lblMesaj.Text = "Daha düşük bir sayı deneyin";
                }
                else
                {
                    lblMesaj.Text = "Tebrikler doğru bildiniz";
                    timer1.Stop();
                    btnTahminEt_Click().Enabled = false; // buton pasif 


                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgBarBilgi.Value++;
            if (prgBarBilgi.Value == 30)
            {
                lblBilgi.Text = "Sürenin yarısı doldu.";
            }
            else if (prgBarBilgi.Value == 60)
            {
                timer1.Stop();
                MessageBox.Show("Süre tamemen doldu. Kaybettiniz");
                panel1.Visible = false;
                btnTahminEt.Enabled = false;


            }

        }
    }
}