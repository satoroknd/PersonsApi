using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.HashService
{
    public class HashService : IHashService
    {
        public string HashPassword(string password)
        {
            using SHA256 sHA256 = SHA256.Create();
            byte[] hashedBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            return hashedPassword;
        }
    }
}
