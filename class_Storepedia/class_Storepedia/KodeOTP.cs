using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace class_Storepedia
{
    public static class KodeOTP
    {
        public static string GenerateKode(string email)
        {
            Random rnd = new Random();

            string kode = rnd.Next(0, 1000000).ToString("D6");

            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "StorepediaAgent@gmail.com",
                    Password = KodeOTP.Decrypt("uVOwvshDf5ugap6LDqjtOl3+EgnZM4bFz5oJsTtTW9c=")
                }
            };

            MailMessage msg = new MailMessage()
            { 
                From = new MailAddress("StorepediaAgent@gmail.com", "Storepedia Support", Encoding.UTF8),
                Subject = "Kode Verifikasi Storepedia",
                Body = $"<p>Kode verifikasi akun Storepedia kamu adalah: <br><code style='font-size:2.5em; line-height:2em'>{kode}</code></p>",
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true,
                Priority = MailPriority.Normal
            };
            msg.To.Add(new MailAddress(email));
            client.SendAsync(msg,"loading");

            return kode;
        }

        private static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("A!9HHhi%XjjYY1452@Nob009X"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
    }
}
