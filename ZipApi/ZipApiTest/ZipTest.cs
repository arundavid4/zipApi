using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace ZipApiTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string path = @"C:\Users\AD00574\Downloads\zip.zip";
            Stream zipresult;
            using (Stream str = new FileStream(path, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read))
            {
                zipresult = Zip.Write(str, 1);
            }
            Assert.AreEqual(((System.IO.FileStream)zipresult).Name, @"C:\Users\AD00574\source\repos\ZipApi\ZipApiTest\bin\Debug\test.zip");
        }
    }
}