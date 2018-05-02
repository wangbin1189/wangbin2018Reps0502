using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PowerKSI.Utils
{
    public class GeneralUtils
    {
        public static string CreateMD5HashedBase64String(string sToHash)
        {
            // get generic MD5 hasher
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            return Convert.ToBase64String(md5Hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(sToHash)));
        }
    }
}