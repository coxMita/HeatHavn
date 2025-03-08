using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace heathavn.Services
{
    public class AssetManager
    {
        public List<Asset> Assets { get; private set; }

        public AssetManager()
        {
            Assets = new List<Asset>();
        }

        public void LoadAssets(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The asset configuration file was not found.", filePath);
            }

            string jsonString = File.ReadAllText(filePath);
            Assets = JsonSerializer.Deserialize<List<Asset>>(jsonString);
        }
    }
}
