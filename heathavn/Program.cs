using Avalonia;
using System;
using System.IO;
// Add the following using to bring in AssetManager
using heathavn.Services;

namespace heathavn;

sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        // Quick test code for AssetManager
        try
        {
            var assetManager = new AssetManager();
            assetManager.LoadAssets("assets.json"); // adjust path if needed

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
