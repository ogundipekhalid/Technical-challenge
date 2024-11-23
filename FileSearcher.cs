using System;
using System.IO;

public class FileSearcher
{
    private readonly string _folderPath;
    private readonly string _searchString;

    public FileSearcher(string folderPath, string searchString)
    {
        _folderPath = folderPath;
        _searchString = searchString;
    }

    public void ScanFiles()
    {
        if (!Directory.Exists(_folderPath))
        {
            Console.WriteLine("Folder path does not exist.");
            return;
        }

        var files = Directory.GetFiles(_folderPath);

        foreach (var file in files)
        {
            bool found = false;

            try
            {
                var content = File.ReadAllText(file);
                if (content.Contains(_searchString))
                {
                    found = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file {file}: {ex.Message}");
                continue;
            }

            if (found)
            {
                Console.WriteLine($"Present: {Path.GetFileName(file)}");
            }
            else
            {
                Console.WriteLine($"Absent: {Path.GetFileName(file)}");
            }
        }
    }
}
