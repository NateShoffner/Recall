using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recall.Models
{
    internal class ServiceStatus
    {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            public DateTime Timestamp { get; set; }

            public bool Enabled { get; set; }
        
    }
}
