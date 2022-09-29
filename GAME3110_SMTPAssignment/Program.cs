using System;
using System.Net;
using System.Net.Mail;

namespace GAME3110_SMTPAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient mMailClient = new SmtpClient();

            MailAddress mFromAddress = new MailAddress("cynicalwithcoffee@gmail.com");
            MailAddress mToAddress = new MailAddress("mparis003@gmail.com");

            MailMessage mMessage = new MailMessage(mFromAddress, mToAddress);
            mMessage.Body = "This is a test message sent by a SMTP application";
            string mUserState = "Test message";
            mMailClient.SendAsync(mMessage, mUserState);
            Console.WriteLine("Sending Message......");
        }
    }
}
