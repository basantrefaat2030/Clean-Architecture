﻿using System;
using System.Collections.Generic;
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
            }
        }
    }
}
