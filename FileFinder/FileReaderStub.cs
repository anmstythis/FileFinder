using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    public class FileReaderStub : IFileReader
    {
        public IEnumerable<string> GetFiles()
        {
            string path = "C:\\Users\\My\\OneDrive\\Документы\\конспекты\\МДК 01\\Поддержка и тестирование программных модулей\\FileFinder\\FileFinder\\bin\\Debug\\files";
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Директория не найдена.");
                return new List<string>();
            }

            var files = Directory.GetFiles(path);

            if (files.Length == 0)
            {
                Console.WriteLine("Файлы не найдены в директории.");
            }
            else
            {
                Console.WriteLine("Найдены файлы:");
                foreach (var file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }

            return files;
        }

        public int GetFileCharacterCount(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                return content.Length;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                return 0;
            }
        }
    }
}
