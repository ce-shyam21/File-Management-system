using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Simple File Manager!");

        Console.Write("Enter operation (create/read/write/delete/move): ");
        string operation = Console.ReadLine();

        Console.Write("Enter file or directory path: ");
        string path = Console.ReadLine();

        switch (operation.ToLower())
        {
            case "create":
                Console.Write("Is it a file or directory? (file/dir): ");
                string type = Console.ReadLine();
                if (type == "file")
                    FileManager.CreateFile(path);
                else
                    FileManager.CreateDirectory(path);
                break;
            case "read":
                FileManager.ReadFile(path);
                break;
            case "write":
                Console.Write("Enter content to write: ");
                string content = Console.ReadLine();
                FileManager.WriteToFile(path, content);
                break;
            case "delete":
                FileManager.DeleteFile(path);
                break;
            case "move":
                Console.Write("Enter destination path: ");
                string destPath = Console.ReadLine();
                FileManager.MoveFile(path, destPath);
                break;
            default:
                Console.WriteLine("Unknown operation");
                break;
        }
    }
}
