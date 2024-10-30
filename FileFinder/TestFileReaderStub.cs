using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    public class TestFileReaderStub : IFileReader
    {
        public IEnumerable<string> GetFiles()
        {
            return new List<string> { "file1.txt", "file2.txt", "file3.txt" };
        }

        public int GetFileCharacterCount(string filePath)
        {
            switch (filePath)
            {
                case "file1.txt":
                    return 100;
                case "file2.txt":
                    return 10;
                case "file3.txt":
                    return 500;
                default:
                    return 0;
            }
        }
    }
}
