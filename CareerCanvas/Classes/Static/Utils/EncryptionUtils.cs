using System.Security.Cryptography;

namespace CareerCanvas.Classes.Static.Utils;

public static class EncryptionUtils
{
    /// <summary>
    /// Encrypts a file using AES encryption and writes the encrypted data to a new file.
    /// </summary>
    /// <param name="inputFile"></param>
    /// <param name="outputFile"></param>
    /// <param name="key"></param>
    public static void EncryptFile(string inputFile, string outputFile, string key, bool removeoriginal = false)
    {
        var plainBytes = File.ReadAllBytes(inputFile);
        var encryptedBytes = EncryptBytesToBytes(plainBytes, key);
        File.WriteAllBytes(outputFile, encryptedBytes);
        if (removeoriginal)
        {
            try
            {
                File.Delete(inputFile);
            }
            catch (Exception ex)
            {
                Globals.AppLogger.Error(ex, "Failed to delete original file after encryption.");
            }
        }
    }

    /// <summary>
    /// Decrypts a file using AES encryption and writes the decrypted data to a new file.
    /// </summary>
    /// <param name="inputFile"></param>
    /// <param name="outputFile"></param>
    /// <param name="key"></param>
    public static void DecryptFile(string inputFile, string outputFile, string key, bool removeoriginal = false)
    {
        var encryptedBytes = File.ReadAllBytes(inputFile);
        var decryptedBytes = DecryptBytesFromBytes(encryptedBytes, key);
        File.WriteAllBytes(outputFile, decryptedBytes);
        if (removeoriginal)
        {
            try
            {
                File.Delete(inputFile);
            }
            catch (Exception ex)
            {
                Globals.AppLogger.Error(ex, "Failed to delete encrypted file after decryption.");
            }
        }
    }

    /// <summary>
    /// Encrypts a file and returns the encrypted data as a byte array.
    /// </summary>
    /// <param name="inputFile"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static byte[] EncryptFileToBytes(string inputFile, string key)
    {
        var plainBytes = File.ReadAllBytes(inputFile);
        return EncryptBytesToBytes(plainBytes, key);
    }

    /// <summary>
    /// Decrypts a file from a byte array and returns the decrypted data as a byte array.
    /// </summary>
    /// <param name="encryptedBytes"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static byte[] DecryptFileFromBytes(byte[] encryptedBytes, string key)
    {
        return DecryptBytesFromBytes(encryptedBytes, key);
    }

    /// <summary>
    /// Generates a random 256-bit key for AES encryption.
    /// </summary>
    /// <returns></returns>
    public static string Generate256BitKey()
    {
        using (var aesAlg = Aes.Create())
        {
            aesAlg.KeySize = 256; // Set the key size to 256 bits
            aesAlg.GenerateKey(); // Generate a random 256-bit key
            return Convert.ToBase64String(aesAlg.Key);
        }
    }

    /// <summary>
    /// Generates a random  512-bit key for AES encryption.
    /// </summary>
    /// <returns></returns>
    public static string Generate512BitKey()
    {
        using (var aesAlg = Aes.Create())
        {
            aesAlg.KeySize = 512; // Set the key size to 512 bits
            aesAlg.GenerateKey(); // Generate a random 512-bit key
            return Convert.ToBase64String(aesAlg.Key);
        }
    }

    /// <summary>
    /// Encrypts a string using AES encryption and returns the encrypted data as a byte array.
    /// </summary>
    /// <param name="plainText"></param>
    /// <param name="key"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Decrypts a byte array using AES encryption and returns the decrypted data as a string.
    /// </summary>
    /// <param name="cipherText"></param>
    /// <param name="key"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Encrypts a byte array using AES encryption and returns the encrypted data as a byte array.
    /// </summary>
    /// <param name="plainBytes"></param>
    /// <param name="key"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Decrypts a byte array using AES encryption and returns the decrypted data as a byte array.
    /// </summary>
    /// <param name="cipherText"></param>
    /// <param name="key"></param>
    /// <returns></returns>
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