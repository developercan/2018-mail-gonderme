using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Yilbasi_yazilimi
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        /*
         * mail'i bu boşlukta tanımladım çünkü form içerisinden gerekli yerlerde içindeki 
         * değerlere erişmek istedim
         */
        string email = "";
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            email = TxtGidenMail.Text;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {/*Zamanlayıcımız sistem içerisindeki saat ile istenilen saati karşılaştırmakta
          *Böylece istenilen vakit geldiğinde işlemimizi gerçekleştirmekte 
          */
            string saat = DateTime.Now.ToShortTimeString();
            if (saat == "00:00")
            {
                mail Mail = new mail();
                Mail.Send(TxtGMail.Text,TxtGMailSifre.Text,email,TxtAd.Text);
            }
        }
    }
}
