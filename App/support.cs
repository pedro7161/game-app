using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace App
{
    public partial class support : Form
    {
        public support()
        {
            InitializeComponent();
        }

     private void button1_Click(object sender, EventArgs e)
        {
         /*   MailAddress from = new MailAddress(textBox1.Text, "Name and stuff");
            MailAddress to = new MailAddress("pedro.ramos9@hotmail.com", "Name and stuff");
            List<MailAddress> cc = new List<MailAddress>();
            cc.Add(new MailAddress("Someone@domain.topleveldomain", "Name and stuff"));
            SendEmail("Want to test this damn thing", from, to, cc);*/
        }
         protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
    {
       /* string Text = "";
        SmtpClient mailClient = new SmtpClient("Mailhost");
        MailMessage msgMail;
        Text = "Stuff";
        msgMail = new MailMessage();
        msgMail.From = _from;
        msgMail.To.Add(_to);
        foreach (MailAddress addr in _cc)
        {
            msgMail.CC.Add(addr);
        }
        if (_bcc != null)
        {
            foreach (MailAddress addr in _bcc)
            {
                msgMail.Bcc.Add(addr);
            }
        }
        msgMail.Subject = _subject;
        msgMail.Body = Text;
        msgMail.IsBodyHtml = true;
        mailClient.Send(msgMail);
        msgMail.Dispose();
    */}

       

        private void button2_Click(object sender, EventArgs e)
        {
            new SmtpClient("smtp.live.com", 25).Send("pedro160100@gmail.com",
                                           "pedro.ramos9@hotmail.com",
                                           textBox3.Text,
                                           textBox4.Text);
            /* try
             {

                 //Sending the email.
                 //Now we must create a new Smtp client to send our email.

                 SmtpClient client = new SmtpClient("smtp.gmail.com", 25);   //smtp.gmail.com // For Gmail
                                                                             //smtp.live.com // Windows live / Hotmail
                                                                             //smtp.mail.yahoo.com // Yahoo
                                                                             //smtp.aim.com // AIM
                                                                             //my.inbox.com // Inbox


                 //Authentication.
                 //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                 NetworkCredential cred = new NetworkCredential("Email", "Password");

                 //To send an email we must first create a new mailMessage(an email) to send.
                 MailMessage Msg = new MailMessage();

                 // Sender e-mail address.
                 Msg.From = new MailAddress(textBox1.Text);//Nothing But Above Credentials or your credentials (*******@gmail.com)

                 // Recipient e-mail address.
                 Msg.To.Add("pedro.ramos9@hotmail.com");

                 // Assign the subject of our message.
                 Msg.Subject = textBox3.Text;

                 // Create the content(body) of our message.
                 Msg.Body = textBox4.Text;

                 // Send our account login details to the client.
                 client.Credentials = cred;

                 //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                 client.EnableSsl = true;

                 //Confirmation After Click the Button
                 label5.Text = "Mail Sended Succesfully";

                 // Send our email.
                 client.Send(Msg);



             }
             catch
             {
                 // If Mail Doesnt Send Error Mesage Will Be Displayed
                 label5.Text = "Error";
             }*/
        }

        private void support_Load(object sender, EventArgs e)
        {

        }
    
    }
}
