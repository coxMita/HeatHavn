using System;
using Xunit;
using heathavn.Services;

namespace heathavn.Tests
{
    public class AssetManagerTests
    {
        [Fact]
        public void LoadAssets_ValidJson_ReturnsAssets()
        {
            // Arrange
            var manager = new AssetManager();
            // Ensure you have a valid assets.json file in the test project's output directory
            string filePath = "assets.json"; 

            // Act
            manager.LoadAssets(filePath);

            // Assert
            Assert.NotEmpty(manager.Assets);
        }
    }
}
