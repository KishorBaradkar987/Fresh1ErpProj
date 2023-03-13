using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseOpworks;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Fresh1ErpProj.Extra
{
    public class Works
    {
        static ERP_ProjectDBEntities db = new ERP_ProjectDBEntities();


        public static string GenerateNewStudentCode()
        {
            try
            {
                int cnt = 0;
                cnt = db.tblstudent_details.Count();
                //if(cnt != null) { 
                string centercode = "SCTI001";
                string lastcode = "";
                if (cnt == 0)
                {
                    lastcode = "0001";
                }
                else if (cnt > 0 && cnt < 10)
                {
                    cnt = cnt + 1;
                    lastcode = "000" + cnt;

                }
                else if (cnt >= 10 && cnt < 100)
                {
                    cnt = cnt + 1;
                    lastcode = "00" + cnt;

                }
                else if (cnt >= 100 && cnt < 1000)
                {
                    cnt = cnt + 1;
                    lastcode = "0" + cnt;

                }

                else if (cnt >= 1000)
                {
                    cnt = cnt + 1;
                    lastcode = "" + cnt;

                }

                string studentcode = centercode + lastcode;
                return studentcode;
                //}
                //else
                //{
                //    string centercode = "SCTI001";
                //    string lastcode = "";
                //    if (cnt == 0)
                //    {
                //        lastcode = "0001";
                //    }
                //    string studentcode = centercode + lastcode;
                //    return studentcode;
                //}
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }



        public static string GetRandomPassword()
        {
            int length = 10;
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public static string GenerateRegistercode()
        {
            int cnt = 0;
            cnt = db.tblstudent_registration_details.Count();

            string centercode = "RCTI001";
            string lastcode = "";
            if (cnt == 0)
            {
                lastcode = "0001";
            }
            else if (cnt > 0 && cnt < 10)
            {
                cnt = cnt + 1;
                lastcode = "000" + cnt;

            }
            else if (cnt >= 10 && cnt < 100)
            {
                cnt = cnt + 1;
                lastcode = "00" + cnt;

            }
            else if (cnt >= 100 && cnt < 1000)
            {
                cnt = cnt + 1;
                lastcode = "0" + cnt;

            }

            else if (cnt >= 1000)
            {
                cnt = cnt + 1;
                lastcode = "" + cnt;

            }

            string registercode = centercode + lastcode;

            return registercode;
        }

        public static void Send_Email(string email, string subject, String description)
        {

            var fromAddress = new MailAddress("kishorbaradkar007@gmail.com", "CIIT Training Institute");
            var toAddress = new MailAddress(email, email);
            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Body = description;
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential networkcred = new NetworkCredential();
            networkcred.UserName = "kishorbaradkar007@gmail.com";
            networkcred.Password = "qxfnvigqygadpebr";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = networkcred;
            smtp.Port = 587;
            smtp.Send(message);
        }
    }
}