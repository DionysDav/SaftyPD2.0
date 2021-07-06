using System.Security.Cryptography;
using System.Text;

namespace Practica1.Security
{
    public class Sha256
    {
        protected SHA256 sha256Hash;

        public Sha256()
        {
            sha256Hash = SHA256.Create();
        }

        public string ComputeSha256Hash(string rawData)
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();  
            for (int i = 0; i < bytes.Length; i++)  
            {  
                builder.Append(bytes[i].ToString("x2"));  
            }  
            return builder.ToString();  
        }
    }
}