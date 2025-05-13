using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecDashboard
{
    public static class BackupManager
    {
        private static readonly string BackupFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../Backups");
        private static readonly string EncryptionKey = "UnfassbaresGeheimnis1";

        private static void EncryptFile(string inputFile, string outputFile)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32).Substring(0, 32));
                byte[] iv = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(16).Substring(0, 16));

                aes.Key = key;
                aes.IV = iv;

                using (FileStream inputStream = File.OpenRead(inputFile))
                using (FileStream outputStream = File.OpenWrite(outputFile))
                using (CryptoStream cryptoStream = new CryptoStream(outputStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputStream.CopyTo(cryptoStream);
                }
            }
        }
        public static void BackupUserData()
        {
            string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../CSVDATA/Benutzerdaten.csv");
            string destPath = Path.Combine(BackupFolder, @"USERDATA/Benutzerdaten_backup.enc");

            if (!Directory.Exists(BackupFolder))
                Directory.CreateDirectory(BackupFolder);

            if (File.Exists(sourcePath))
                EncryptFile(sourcePath, destPath);
        }

        public static void BackupLoginHistory()
        {
            string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../login_history.sqlite");
            string destPath = Path.Combine(BackupFolder, @"LHDATA/login_history_backup.enc");

            if (!Directory.Exists(BackupFolder))
                Directory.CreateDirectory(BackupFolder);

            if (File.Exists(sourcePath))
                EncryptFile(sourcePath, destPath);
        }
        public static void DecryptFileAndRestore(string encryptedPath, string outputpath)
        {
            byte[] key = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32).Substring(0, 32));
            byte[] iv = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(16).Substring(0, 16));
            using (FileStream inputFilestream = new FileStream(encryptedPath, FileMode.Open))
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (CryptoStream cryptostream = new CryptoStream(inputFilestream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (FileStream outputFileStream = new FileStream(outputpath, FileMode.Create))
                {
                    cryptostream.CopyTo(outputFileStream);
                }
            }
        }
                


        public static void BackupAll()
        {
            BackupUserData();
            BackupLoginHistory();
        }
    }
}
