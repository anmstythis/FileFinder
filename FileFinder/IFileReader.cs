﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    public interface IFileReader
    {
        IEnumerable<string> GetFiles();
        int GetFileCharacterCount(string filePath);
    }
}
