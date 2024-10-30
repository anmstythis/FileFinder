using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    public class FileProcessor
    {
        private readonly IFileReader _fileReader;

        public FileProcessor(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public List<string> FindFilesByCharacterCount(int characterCount)
        {
            return _fileReader.GetFiles()
                              .Where(file => _fileReader.GetFileCharacterCount(file) == characterCount)
                              .ToList();
        }
    }
}
