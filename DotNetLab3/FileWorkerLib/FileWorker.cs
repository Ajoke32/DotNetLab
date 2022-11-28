using System.Security.Cryptography;
using System.ComponentModel;
using System.Diagnostics;


namespace FileWorkerLib
{
    public class FileWorker
    {
        public BackgroundWorker background;
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;
        
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        public bool isEncrypt = false;
        public static int per;
        private Stopwatch stopWatch;
        private string fileName;
        public string? Info { get; set; }
        public string? Key { get; set; }
        public FileWorker()
        {
            #pragma warning disable CA1416
            _cspp.KeyContainerName = Key;
            _rsa = new RSACryptoServiceProvider(_cspp)
            {
                PersistKeyInCsp = true
            };
            #pragma warning restore CA1416
            background = new BackgroundWorker();
            stopWatch = new Stopwatch();
            background.WorkerReportsProgress = true;
        }
        
     
        private void WorkAsync(object? sender, DoWorkEventArgs e)
        {
           
            if (e.Argument is FileInfo)
            {
                var argument = e.Argument as FileInfo;
                stopWatch.Start();
                if (isEncrypt)
                {
                    EncryptFile(argument);
                }
                else
                {
                    DecryptFile(argument);
                }
                stopWatch.Stop();
                var fi = new FileInfo($@"{EncrFolder}\{Path.ChangeExtension(argument.Name, "enc")}");
                Info = $"Operation time:{stopWatch.Elapsed.Milliseconds}\n File size:{fi.Length}\nFile name:{fi.Name}";
            }
        }
        public void DoEncryption(FileInfo file)
        {
            background.DoWork += WorkAsync;
           
            if (!background.IsBusy)
            {
                background.RunWorkerAsync(file);
            }
            
        }

        private void EncryptFile(FileInfo file)
        {
    
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();
            

            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

       
            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            string outFile =
                Path.Combine(EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using (var outFstream = new FileStream(outFile, FileMode.Create))
            {
                outFstream.Write(LenK, 0, 4);
                outFstream.Write(LenIV, 0, 4);
                outFstream.Write(keyEncrypted, 0, lKey);
                outFstream.Write(aes.IV, 0, lIV);

                using (var outStreamEncrypted =
                    new CryptoStream(outFstream, transform, CryptoStreamMode.Write))
                {
          
                    int count = 0;
                    int offset = 0;
                    var byteCout = file.Length;
                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;
                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            int percent = (int)(bytesRead * 100.0 / (int)byteCout);
                            if (percent != 0&&percent %20==0)
                            {
                                background.ReportProgress((int)percent);
                            }
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock();
                }
            }
        }
        private void DecryptFile(FileInfo file)
        {
            Aes aes = Aes.Create();

            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Encrypt", "Decrypt"), ".txt");

            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);


                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                Directory.CreateDirectory(DecrFolder);
   
                byte[] KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);

                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                using (var outFs = new FileStream(outFile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                 
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (var outStreamDecrypted =
                        new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        } while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                    }
                }
            }
        }
    }
}