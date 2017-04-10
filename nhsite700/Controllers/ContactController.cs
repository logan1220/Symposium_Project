using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using nhsite700.Models;

namespace nhsite700.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel e)
        {
            if (ModelState.IsValid)
            {

                //prepare email
                var toAddress = "student.nerdherd@gmail.com";
                var fromAddress = e.Email.ToString();
                var subject = e.Subject.ToString();
                var message = new StringBuilder();
                message.Append("Name: " + e.Name + "\n");
                message.Append("Email: " + e.Email + "\n");
                message.Append(e.Comment);

                //start email Thread
                SendEmail(toAddress, fromAddress, subject, message);
            }

            return View();
        }

        public void SendEmail(string toAddress, string fromAddress, string subject, StringBuilder message)
        {
            try
            {
                using (var mail = new MailMessage())
                {
                    const string email = "student.nerdherd@gmail.com";
                    const string password = "76YMUT979IHl";

                    var loginInfo = new NetworkCredential(email, password);


                    mail.From = new MailAddress(fromAddress);
                    mail.To.Add(new MailAddress(toAddress));
                    mail.Subject = subject;
                    mail.Body = message.ToString();
                    mail.IsBodyHtml = true;

                    try
                    {
                        using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtpClient.EnableSsl = true;
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = loginInfo;
                            smtpClient.Send(mail);
                        }

                    }

                    finally
                    {
                        //dispose the client
                        mail.Dispose();
                    }

                }
            }
            catch (SmtpFailedRecipientsException ex)
            {
                foreach (SmtpFailedRecipientException t in ex.InnerExceptions)
                {
                    var status = t.StatusCode;
                    if (status == SmtpStatusCode.MailboxBusy ||
                        status == SmtpStatusCode.MailboxUnavailable)
                    {
                        Response.Write("Delivery failed - retrying in 5 seconds.");
                        System.Threading.Thread.Sleep(5000);
                        //resend
                        //smtpClient.Send(message);
                    }
                    else
                    {
                        Response.Write("Failed to deliver message");
                    }
                }
            }
            catch (SmtpException Se)
            {
                // handle exception here
                Response.Write(Se.ToString());
            }

            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }
    }
}