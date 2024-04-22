using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farhang_Loqat
{
    public partial class FrmClose : Form
    {
        public FrmClose()
        {
            InitializeComponent();
        }
        string matn = "";
        Form1 frm1 = new Form1();
       //textbox daryaft nazar
        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            matn = txtComment.Text;
        }

        //methode baraye sabt nazar
        public void comment(string matn)
        {
            MailMessage n = new MailMessage();
            n.From = new MailAddress("nazaratmail68@gmail.com", "DictionaryTest");
            n.To.Add("sadatmusavi2000@gmail.com");
            n.Subject = "گزارش";
            n.Body = matn;
            SmtpClient sc = new SmtpClient("smtp.gmail.com");
            sc.Port = 587;
            sc.Credentials = new NetworkCredential("nazaratmail68@gmail.com", "68nazaratmail68");
            sc.EnableSsl = true;
            sc.Send(n);

        }
        FrmError fe = new FrmError();
        FrmAccept fa = new FrmAccept();
        //button sabt nazar
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                comment(matn);
                fa.ShowDialog();
                frmAssli();
               

            }
            catch (Exception)
            {
               fe.ShowDialog();
            }

        }
        //tabe baraye bastan form ha
        public void frmAssli()
        {
            var form = Application.OpenForms["FrmAsli"];
            var fform = Application.OpenForms["Form1"];
            if (form == null || fform == null)
            {
                form = new FrmAsli();
                fform = new Form1();
                
            }
            form.Close();
            fform.Close();

        }
        //button khorooj
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmAssli();
        }
    }
}
