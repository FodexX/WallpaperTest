using ClassLibrary;

namespace WallpaperTests
{
    [TestClass]
    public class WallpaperSelectorTests
    {
        [TestMethod]
        public void Test_GetWallpapersByTag()
        {
            var selector = new WallpaperSelector();

            var natureWallpaper = new Wallpaper("Лес", new List<string> { "Природа", "Зелень" });
            var sportsWallpaper = new Wallpaper("Футбол", new List<string> { "Спорт", "Действие" });
            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTag("Природа");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Лес", result[0].Name);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag_NoResults()
        {
            var selector = new WallpaperSelector();
            var natureWallpaper = new Wallpaper("Горы", new List<string> { "Природа" });
            selector.AddWallpaper(natureWallpaper);

            var result = selector.GetWallpapersByTag("Спорт");

            Assert.AreEqual(0, result.Count);
        }
    }
}
