using System.Reflection;

namespace AppConfigurationTools.Services;

internal static class DetectingDatabaseFiles
{
    internal static List<string> GetDbFilePaths()
    {
        var currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;

        var dbFilePaths = Directory.GetFiles(currentDirectory)
            .Where(f => f.ToLower().EndsWith(".db"))
            .ToList();

        return dbFilePaths;
        
    }
}
