﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fıtness
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullaniciTb.Text==""||SifreTb.Text=="")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else if(KullaniciTb.Text=="admin"&& SifreTb.Text=="1234")
            {
                AnaSayfa anaSayfa= new AnaSayfa();  
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı yada Şifre");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
