using Recall.Models;
using SQLite;
using System.Diagnostics;
using System.Timers;

namespace Recall.Services
{
    public class RecallService
    {
        private bool _enabled;
        private ScreenshotService _screenshotService;

        public bool Enabled
        {
            get
            {
                return _enabled;
            }

            set
            {
                if (value == _enabled)
                {
                    return;
                }
                Debug.WriteLine($"Recall service enabled: {value}");
                _enabled = value;

                ServiceStatus status = new ServiceStatus
                {
                    Enabled = _enabled,
                    Timestamp = DateTime.Now
                };
                _db.Insert(status);

                if (_enabled)
                {
                    _screenshotTimer.Start();
                    _analysisTimer.Start();
                }
                else
                {
                    _screenshotTimer.Stop();
                    _analysisTimer.Stop();
                }
            }
        }
        private System.Timers.Timer _screenshotTimer;
        private System.Timers.Timer _analysisTimer;
        private Screenshot _lastScreenshot;

        private AnalysisService _analysisService;

        private SQLiteConnection _db;

        public RecallService(string databasePath, int tickRate = 5000)
        {
            _db = new SQLiteConnection(databasePath);
            _db.CreateTable<Screenshot>();
            _db.CreateTable<Analysis>();
            _db.CreateTable<ServiceStatus>();

            string workingDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            _screenshotService = new ScreenshotService(workingDir);

            _analysisService = new AnalysisService(_db);

            _screenshotTimer = new System.Timers.Timer(tickRate);
            _screenshotTimer.Elapsed += _timer_Elapsed;

            _analysisTimer = new System.Timers.Timer(tickRate * 2);
            _analysisTimer.Elapsed += _analysisTimer_Elapsed;
        }

        private void _analysisTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Debug.WriteLine("Starting analysis...");
            try
            {
                _analysisService.AnaylizeScreenshot(_lastScreenshot);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Debug.WriteLine("Preparing to capture screenshot...");
            try
            {
                string path = _screenshotService.CaptureScreen();


                Screenshot s = new Screenshot
                {
                    Path = path,
                    Taken = DateTime.Now,
                    Size = new FileInfo(path).Length
                };

                _db.Insert(s);
                _lastScreenshot = s;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
