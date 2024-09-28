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

            var natureWallpaper = new Wallpaper("���", new List<string> { "�������", "������" });
            var sportsWallpaper = new Wallpaper("������", new List<string> { "�����", "��������" });
            selector.AddWallpaper(natureWallpaper);
            selector.AddWallpaper(sportsWallpaper);

            var result = selector.GetWallpapersByTag("�������");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("���", result[0].Name);
        }

        [TestMethod]
        public void Test_GetWallpapersByTag_NoResults()
        {
            var selector = new WallpaperSelector();
            var natureWallpaper = new Wallpaper("����", new List<string> { "�������" });
            selector.AddWallpaper(natureWallpaper);

            var result = selector.GetWallpapersByTag("�����");

            Assert.AreEqual(0, result.Count);
        }
    }
}
