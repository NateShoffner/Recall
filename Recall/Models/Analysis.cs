using SQLite;

namespace Recall.Models
{
    public class Analysis
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public DateTime Created { get; set; }

        public string Model { get; set; }

        [Indexed]
        public int ScreenshotId { get; set; }
    }
}
