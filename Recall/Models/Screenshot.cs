using SQLite;

namespace Recall.Models
{
    public class Screenshot
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Path { get; set; }
        public DateTime Taken { get; set; }

        public long Size { get; set; }
    }
}
