NETWORK PROGRAMMING ASSIGNMENTS
Student: Aisha Ali Ibrahim Osman

Contents
1) 01_UDP_Chat_File_Transfer
   UDP chat client/server and file transfer.
2) 02_Text_and_Binary_Streams
   Text stream and binary stream demonstration.
3) 03_Database_to_Stream
   Demonstrates writing a student table to a MemoryStream and reading it back.
4) Explanation.pdf
   Arabic explanation of the three assignments.
5) Build-Windows.bat
   Builds Windows executables using the .NET 8 SDK.

How to run
- Install .NET 8 SDK on Windows.
- Open Command Prompt in this folder.
- Run Build-Windows.bat.
- For the UDP project, open two command windows:
  Server: dotnet run --project 01_UDP_Chat_File_Transfer -- server
  Client: dotnet run --project 01_UDP_Chat_File_Transfer -- client
- In the client, type a message to chat.
- To send a file, type: /file C:\full\path\to\file.pdf
- The server saves received files in its ReceivedFiles folder.

Important notes
- UDP does not guarantee delivery or packet order. This educational example sends file chunks but does not implement acknowledgements/retransmission. For important files, TCP or a reliable UDP protocol is preferable.
- The third assignment uses a DataTable as a small in-memory database to demonstrate writing database records into a stream. It does not require an external database server.
- This package contains source code and build instructions. A Windows EXE cannot be compiled in this environment because the .NET SDK/compiler is not installed. Run Build-Windows.bat on a Windows computer with .NET 8 SDK to generate the EXE files.
