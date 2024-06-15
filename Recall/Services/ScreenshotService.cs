using System.Diagnostics;
using System.Drawing.Imaging;

namespace Recall.Services
{


    internal class ScreenshotService
    {
        private string _workingDir;

        public ScreenshotService(string workingDir)
        {
            _workingDir = workingDir;
        }

        public string CaptureScreen()
        {
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(screenSize.Width, screenSize.Height);

            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(Point.Empty, Point.Empty, screenSize.Size);
            }

            string path = Path.Combine(_workingDir, $"{DateTime.Now:yyyyMMddHHmmss}.png");
            screenshot.Save(path, ImageFormat.Png);
            Debug.WriteLine($"Screenshot saved to {path}");
            return path;
        }
    }
}
