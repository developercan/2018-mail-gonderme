using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Yilbasi_yazilimi
{
    class mail
    {
        public void Send(string gonderilen_mail,string sifre,string mail,string ad)
        {
            try
            {
                //standart mail gönderme işlemleri
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp-mail.outlook.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(gonderilen_mail, sifre);
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(gonderilen_mail, ad);
                msg.To.Add(mail);
                msg.Subject = "mutlu yıllar";
                msg.IsBodyHtml = true;
                msg.Body = "Musmutlu yıllar "+ad;
                sc.Send(msg);
                //Başarılı olduysa başarılı mesajı gönderme
                MessageBox.Show("Mail gönderildi", "işlem başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Hatalı olduysa hatalı oldu mesajı gönderme işlemi uygulanır
                MessageBox.Show("Bir hata ile karşılaşıldı " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
