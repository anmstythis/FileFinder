using System;
using System.Collections.Generic;
using System.IO;

namespace FileFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов для поиска файлов:");
            if (!int.TryParse(Console.ReadLine(), out int characterCount))
            {
                Console.WriteLine("Некорректное значение для количества символов.");
                return;
            }

            IFileReader fileReader = new FileReaderStub();
            FileProcessor fileProcessor = new FileProcessor(fileReader);

            List<string> matchingFiles = fileProcessor.FindFilesByCharacterCount(characterCount);

            if (matchingFiles.Count > 0)
            {
                Console.WriteLine($"\nФайлы с количеством символов {characterCount}:");
                foreach (var file in matchingFiles)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
            else
            {
                Console.WriteLine("\nФайлы с указанным количеством символов не найдены.");
            }
        }
    }
}
