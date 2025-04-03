using System.Security.Cryptography;

namespace CareerCanvas.Classes.Static.Utils;

public static class EncryptionUtils
{
    public static void EncryptFile(string inputFile, string outputFile, string key)
    {
        var plainBytes = File.ReadAllBytes(inputFile);
        var encryptedBytes = EncryptBytesToBytes(plainBytes, key);
        File.WriteAllBytes(outputFile, encryptedBytes);
    }

    public static void DecryptFile(string inputFile, string outputFile, string key)
    {
        var encryptedBytes = File.ReadAllBytes(inputFile);
        var decryptedBytes = DecryptBytesFromBytes(encryptedBytes, key);
        File.WriteAllBytes(outputFile, decryptedBytes);
    }

    public static byte[] EncryptFileToBytes(string inputFile, string key)
    {
        var plainBytes = File.ReadAllBytes(inputFile);
        return EncryptBytesToBytes(plainBytes, key);
    }

    public static byte[] DecryptFileFromBytes(byte[] encryptedBytes, string key)
    {
        return DecryptBytesFromBytes(encryptedBytes, key);
    }

    public static string Generate256BitKey()
    {
        using (var aesAlg = Aes.Create())
        {
            aesAlg.KeySize = 256; // Set the key size to 256 bits
            aesAlg.GenerateKey(); // Generate a random 256-bit key
            return Convert.ToBase64String(aesAlg.Key);
        }
    }

    public static byte[] EncryptStringToBytes(string plainText, string key)
    {
        byte[] encrypted;

        using (var aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(key);
            aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // IV should be the same size as the block size
            aesAlg.Mode = CipherMode.CBC; // Set the mode to CBC
            aesAlg.Padding = PaddingMode.PKCS7; // Use PKCS7 padding

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (var msEncrypt = new MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (var swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(plainText);
                }

                encrypted = msEncrypt.ToArray();
            }
        }

        return encrypted;
    }

    public static string DecryptStringFromBytes(byte[] cipherText, string key)
    {
        string plaintext = null;

        using (var aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(key);
            aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // IV should be the same size as the block size
            aesAlg.Mode = CipherMode.CBC; // Set the mode to CBC
            aesAlg.Padding = PaddingMode.PKCS7; // Use PKCS7 padding

            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (var msDecrypt = new MemoryStream(cipherText))
            using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (var srDecrypt = new StreamReader(csDecrypt))
            {
                plaintext = srDecrypt.ReadToEnd();
            }
        }

        return plaintext;
    }

    public static byte[] EncryptBytesToBytes(byte[] plainBytes, string key)
    {
        byte[] encrypted;

        using (var aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(key);
            aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // IV should be the same size as the block size
            aesAlg.Mode = CipherMode.CBC; // Set the mode to CBC
            aesAlg.Padding = PaddingMode.PKCS7; // Use PKCS7 padding

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (var msEncrypt = new MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                }

                encrypted = msEncrypt.ToArray();
            }
        }

        return encrypted;
    }

    public static byte[] DecryptBytesFromBytes(byte[] cipherText, string key)
    {
        byte[] plaintext;

        using (var aesAlg = Aes.Create())
        {
            aesAlg.Key = Convert.FromBase64String(key);
            aesAlg.IV = new byte[aesAlg.BlockSize / 8];
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.Padding = PaddingMode.PKCS7;

            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (var msDecrypt = new MemoryStream(cipherText))
            using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (var msPlainText = new MemoryStream())
            {
                csDecrypt.CopyTo(msPlainText);
                plaintext = msPlainText.ToArray();
            }
        }

        return plaintext;
    }
}