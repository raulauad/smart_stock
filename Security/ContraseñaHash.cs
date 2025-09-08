using System.Security.Cryptography;
using System.Text;

namespace smart_stock.Security
{
    public class ContraseñaHash
    {
        public string Hash(string input)
        {
            using var sha = SHA256.Create();
            var bytes =
                sha.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToHexString(bytes);
        }

        public bool Verificar(string input, string hash) => 
            string.Equals(Hash(input), hash,
                StringComparison.Ordinal);
    }
}
