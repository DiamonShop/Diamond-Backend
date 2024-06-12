using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random key
        var key = GenerateRandomKey(64);
        Console.WriteLine("Random Key: " + key);
    }

    static string GenerateRandomKey(int length)
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            var bytes = new byte[length];
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}
