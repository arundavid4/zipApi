using System.IO.Compression;
public static class Zip
{
    // Write a zip file with specified number of 1MiB each with random content.
    public static Stream Write(Stream stream, int files)
    {
        string path = "../test.zip";
        Stream str = new FileStream(path, FileMode.Append);

        using (var retur = new ZipArchive(str, ZipArchiveMode.Create))
        {
            var buffer = new byte[0x100000];
            for (var i = 0; i < files; i++)
            {
                int length = stream.Read(buffer, 0, 100000);
                var name = i.ToString();
                var entry = retur.CreateEntry(name);
                using (var entryStream = entry.Open())
                {
                    entryStream.Write(buffer, 0, length);
                }
            }
        }
        return str;
    }

}



