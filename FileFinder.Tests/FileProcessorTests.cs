using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileFinder.Tests
{
    [TestClass]
    public class FileProcessorTests
    {
        [TestMethod]
        public void FindFilesByCharacterCount_500symb_2return()
        {
            //var fileReader = new TestFileReaderStub();
            var fileReader = new FileReaderStub();
            var fileProcessor = new FileProcessor(fileReader);
            int targetCharacterCount = 500;

            List<string> result = fileProcessor.FindFilesByCharacterCount(targetCharacterCount);

            Assert.AreEqual(2, result.Count);
        }
    }
}
