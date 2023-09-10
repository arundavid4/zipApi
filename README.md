# zipApi
Minimal API to create a zip file using stream I/O

* Created a minimal api using dotnet 7
* New GET endpoint app.MapGet("/{files}", ...) added.
* Changes made to the zip.cs :
    - new zip archive is created in the local to write 1 mb files to the local bin.
    - write back the local zip stream created.



