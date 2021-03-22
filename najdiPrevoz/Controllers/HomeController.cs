using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using najdiPrevoz.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace najdiPrevoz.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Contact()
        {
            ViewBag.Message = "Test Form";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(MailModels e)
        {
            if (ModelState.IsValid)
            {

                StringBuilder message = new StringBuilder();
                MailAddress from = new MailAddress(e.Email.ToString());
                message.Append("Name: " + e.Ime + "\n");
                message.Append("Email: " + e.Email + "\n");
                message.Append("Telephone: " + e.Telephone + "\n\n");
                message.Append(e.Message);

                MailMessage mail = new MailMessage();

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.mail.yahoo.com";
                smtp.Port = 465;

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("yahooaccount", "yahoopassword");

                smtp.Credentials = credentials;
                smtp.EnableSsl = true;

                mail.From = from;
                mail.To.Add("andrea.galevska@gmail.com");
                mail.Subject = "Test enquiry from " + e.Ime;
                mail.Body = message.ToString();

                smtp.Send(mail);
            }
            return View();
        }
        public ActionResult Index()
        {
            
            int max = 0;
            ApplicationUser indeks = new ApplicationUser();
            List<ApplicationUser> lista = db.Users.ToList();
            List<ApplicationUser> najdobri = new List<ApplicationUser>();

            for (int i = 0; i < 5; i++)
            {
                max = 0;

                foreach (ApplicationUser u in lista)
                {
                    if (u.countLikes > max)
                    {
                        max = u.countLikes;
                        indeks = u;
                    }

                }
                najdobri.Add(indeks);
                lista.Remove(indeks);
            }

            return View(najdobri);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MyTrips()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("MyTrips", "Trips");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public FileContentResult UserPhotos()
        {
            if (User.Identity.IsAuthenticated)
            {
                String userId = User.Identity.GetUserId();

                if (userId == null)
                {
                    string fileName = HttpContext.Server.MapPath(@"~/Images/login.jfif");

                    byte[] imageData = null;
                    FileInfo fileInfo = new FileInfo(fileName);
                    long imageFileLength = fileInfo.Length;
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imageData = br.ReadBytes((int)imageFileLength);
                    return File(imageData, "image/png");

                }

                // to get the user details to load user Image    
                var bdUsers = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
                var userImage = bdUsers.Users.Where(x => x.Id == userId).FirstOrDefault();

                var img = bdUsers.Users.Where(x => x.Id == userId).FirstOrDefault().UserPhoto;
                if (img != null && img.Length != 0)
                {
                    return new FileContentResult(userImage.UserPhoto, "image/jpeg");

                }

                else
                {
                    string fileName = HttpContext.Server.MapPath(@"~/Images/noImage.png");

                    byte[] imageData = null;
                    FileInfo fileInfo = new FileInfo(fileName);
                    long imageFileLength = fileInfo.Length;
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imageData = br.ReadBytes((int)imageFileLength);
                    return File(imageData, "image/png");
                }
            }
            else
            {
                string fileName = HttpContext.Server.MapPath(@"~/Images/login.jfif");

                byte[] imageData = null;
                FileInfo fileInfo = new FileInfo(fileName);
                long imageFileLength = fileInfo.Length;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)imageFileLength);
                return File(imageData, "image/png");

            }
        }
    }
}