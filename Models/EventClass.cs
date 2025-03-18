using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.Models
{
    public class EventClass
    {
        [PrimaryKey, AutoIncrement]
        public int event_ID { get; set; }
        public string event_Type { get; set; }
    }
}
