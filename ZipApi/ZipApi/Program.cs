
using System.IO.Compression;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Sockets;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/{files}", async (int count, string path) =>
{
    
    using (Stream str = new FileStream(path, FileMode.Append))
    {
        Stream entries =
         Zip.Write(str, count);
        return Results.File(entries, "application /octet -stream", "test.zip");
    }
});

app.Run();
