using Avalonia;
using System;
using System.IO;
using heathavn.Services; // Ensure this matches the namespace of your AssetManager

namespace heathavn;

sealed class Program
{
    // This is the only Main method in your project.
    [STAThread]
    public static void Main(string[] args)
    {
        // Quick test code for AssetManager
        try
        {
            var assetManager = new AssetManager();
            assetManager.LoadAssets("assets.json"); // adjust the path if needed

            Console.WriteLine("Assets loaded successfully:");
            foreach (var asset in assetManager.Assets)
            {
                Console.WriteLine($"ID: {asset.Id}, Name: {asset.Name}, Type: {asset.Type}, Location: {asset.Location}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading assets: {ex.Message}");
        }

        // Continue with Avalonia startup
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
                     .UsePlatformDetect()
                     .WithInterFont()
                     .LogToTrace();
}
