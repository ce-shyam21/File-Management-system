using System;
using System.IO;

class FileManager
{
    public static void CreateDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory created: " + path);
        }
        else
        {
            Console.WriteLine("Directory already exists: " + path);
        }
    }

    public static void CreateFile(string path)
    {
        if (!File.Exists(path))
        {
            using (FileStream fs = File.Create(path))
            {
                Console.WriteLine("File created: " + path);
            }
        }
        else
        {
            Console.WriteLine("File already exists: " + path);
        }
    }

    public static void ReadFile(string path)
    {
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("File content:\n" + content);
        }
        else
        {
            Console.WriteLine("File not found: " + path);
        }
    }

    public static void WriteToFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine("Content written to file: " + path);
    }

    public static void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File deleted: " + path);
        }
        else
        {
            Console.WriteLine("File not found: " + path);
        }
    }

    public static void MoveFile(string sourcePath, string destPath)
    {
        if (File.Exists(sourcePath))
        {
            File.Move(sourcePath, destPath);
            Console.WriteLine($"File moved from {sourcePath} to {destPath}");
        }
        else
        {
            Console.WriteLine("Source file not found: " + sourcePath);
        }
    }
}
