using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICompression
    {
        void CompressFile(string sourcePath);
    }

    public class CompressionService : ICompression
    {
        public void CompressFile(string sourcePath)
        {
            if (System.IO.File.Exists(sourcePath))
            {
                //string compressedFilePath = Path.Combine(Path.GetDirectoryName(sourcePath), $"{Path.GetFileName(filePath)}.gz");

                string sqlContent = File.ReadAllText(sourcePath);

                // Convert the SQL content to bytes
                byte[] sqlBytes = Encoding.UTF8.GetBytes(sqlContent);

                // Overwrite the original file with compressed data
                using (FileStream fs = new FileStream(sourcePath, FileMode.Create))
                using (GZipStream gzip = new GZipStream(fs, CompressionLevel.Optimal))
                {
                    gzip.Write(sqlBytes, 0, sqlBytes.Length);
                }
            }
        }
    }
}
