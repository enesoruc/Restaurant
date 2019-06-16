using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tukkan
{
    public partial class Form1 : Form
    {
        RadioButton rb = new RadioButton();
        double toplam = 0;
        double porsiyonFiyat = 0;
        bool menuSecildimi = false;
        bool porsiyonSecildimi = false;
        bool menuAdetSecildimi = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            txtToplamTutar.Clear();
            txtSiparisler.Clear();
            int menuSecFiyat = MenuSec();
            double porsiyonFiyatson = PorsiyonSec();
            double ekstraFiyat = EkstraSecim();
            int adet = MenuAdetAl();
            if (menuAdetSecildimi && porsiyonSecildimi && menuAdetSecildimi && menuSecildimi)
            {
                double sonFiyat = ((menuSecFiyat * porsiyonFiyat) + ekstraFiyat) * adet;
                txtToplamTutar.Text = sonFiyat.ToString();
            }
            else
            {
                txtSiparisler.Clear();
                txtToplamTutar.Text = string.Empty;
                MessageBox.Show("Lütfen gerekli seçimleri gerçekleştiriniz");
                
            }
            AllButonsUnCkecked();

        }

        private int MenuAdetAl()
        {
            int menuAdet = 0;
            if (cmbMenu.Text == null)
            {
                menuAdetSecildimi = false;
            }
            else
            {
                switch (cmbMenuAdet.Text)
                {
                    case "1":
                        menuAdet = 1;
                        break;
                    case "2":
                        menuAdet = 2;
                        break;
                    case "3":
                        menuAdet = 3;
                        break;
                    case "4":
                        menuAdet = 4;
                        break;
                    case "5":
                        menuAdet = 5;
                        break;
                    default:
                        menuAdet = 1;
                        break;
                }
                menuAdetSecildimi = true;
            }
            return menuAdet;
        }
        private double PorsiyonSec()
        {
            string secim = string.Empty;
            if (!rdButonTam.Checked && !rdButonYarim.Checked)
            {
                MessageBox.Show("Porsiyon Seçimi Yapılmadı");
                porsiyonSecildimi = false;
            }
            else
            {
                if (rdButonTam.Checked)
                {
                    secim += rdButonTam.Text;
                    porsiyonFiyat = 1;
                }
                else if (rdButonYarim.Checked)
                {
                    secim += rdButonYarim.Text;
                    porsiyonFiyat = 0.5;
                }
                porsiyonSecildimi = true;
                txtSiparisler.Text += secim + " Porsiyon ";
            }
            return porsiyonFiyat;

        }
        private double EkstraSecim()
        {
            string secim = string.Empty;
            if (chkKetcap.Checked || ChkMayonez.Checked || chkTursu.Checked || chkSogan.Checked || chkAciSos.Checked || chkPatates.Checked || chkHardal.Checked || chkRanch.Checked)
            {
                toplam = 0;
                if (chkKetcap.Checked)
                {
                    secim += chkKetcap.Text + ",";
                    toplam += 2.5;
                }
                if (ChkMayonez.Checked)
                {
                    secim += ChkMayonez.Text + ",";
                    toplam += 2.5;
                }
                if (chkTursu.Checked)
                {
                    secim += chkTursu.Text + ",";
                    toplam += 2.5;
                }
                if (chkSogan.Checked)
                {
                    secim += chkSogan.Text + ",";
                    toplam += 2.5;
                }
                if (chkAciSos.Checked)
                {
                    secim += chkAciSos.Text + ",";
                    toplam += 2.5;
                }
                if (chkPatates.Checked)
                {
                    secim += chkPatates.Text + ",";
                    toplam += 2.5;
                }
                if (chkHardal.Checked)
                {
                    secim += chkHardal.Text + ",";
                    toplam += 2.5;
                }
                if (chkRanch.Checked)
                {
                    secim += chkRanch.Text + ",";
                    toplam += 2.5;
                }
                
                txtSiparisler.Text += secim + " ekstraları ile birlikte ";
                txtToplamTutar.Text += toplam;
            }
            return toplam;
        }
        private void AllButonsUnCkecked()
        {
            
            cmbMenuAdet.SelectedItem = null;
            cmbMenu.SelectedItem = null;
            rdButonYarim.Checked = false;
            rdButonTam.Checked = false;
            chkKetcap.Checked = false;
            ChkMayonez.Checked = false;
            chkTursu.Checked = false;
            chkSogan.Checked = false;
            chkAciSos.Checked = false;
            chkPatates.Checked = false;
            chkHardal.Checked = false;
            chkRanch.Checked = false;
        }
        private int MenuSec()
        {
            int secilenMenuFiyat = 0;
            if (cmbMenu.SelectedIndex > -1)
            {
                txtSiparisler.Text += cmbMenu.SelectedItem.ToString();
                switch (cmbMenu.Text)
                {
                    case "Tavuk Menü":
                        secilenMenuFiyat = 15;
                        break;
                    case "Et Döner Menü":
                        secilenMenuFiyat = 21;
                        break;
                    case "Tombik Döner":
                        secilenMenuFiyat = 25;
                        break;
                    case "Pirzola Menü":
                        secilenMenuFiyat = 45;
                        break;

                }
                menuSecildimi = true;
            }
            else
            {
                MessageBox.Show("Menü Seçim yapılmadı");
                menuSecildimi = false;
            }
            return secilenMenuFiyat;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {

        }
    }
}

