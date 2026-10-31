using System.Data;
using System.Text;

// A small in-memory student table represents a simple database.
// The table is written to a MemoryStream and then read back.

DataTable students = new DataTable("Students");
students.Columns.Add("ID", typeof(int));
students.Columns.Add("Name", typeof(string));
students.Columns.Add("Department", typeof(string));

students.Rows.Add(1, "Aisha", "Information Technology");
students.Rows.Add(2, "Sara", "Computer Science");
students.Rows.Add(3, "Mona", "Information Systems");

using MemoryStream memory = new MemoryStream();

// WRITE database rows to a stream.
using (BinaryWriter writer = new BinaryWriter(memory, Encoding.UTF8, leaveOpen: true))
{
    writer.Write(students.Rows.Count);

    foreach (DataRow row in students.Rows)
    {
        writer.Write((int)row["ID"]);
        writer.Write((string)row["Name"]);
        writer.Write((string)row["Department"]);
    }
}

Console.WriteLine("Database table was written to MemoryStream.");

// READ the stream and display the rows.
memory.Position = 0;
Console.WriteLine("\nSTUDENT RECORDS:");

using (BinaryReader reader = new BinaryReader(memory, Encoding.UTF8, leaveOpen: true))
{
    int numberOfRows = reader.ReadInt32();

    for (int i = 0; i < numberOfRows; i++)
    {
        int id = reader.ReadInt32();
        string name = reader.ReadString();
        string department = reader.ReadString();

        Console.WriteLine($"ID: {id} | Name: {name} | Department: {department}");
    }
}

Console.WriteLine("\nFinished reading database data from the stream.");
