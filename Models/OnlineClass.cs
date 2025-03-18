using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.Models
{
    public class OnlineClass
    {
        [PrimaryKey, AutoIncrement]
        public int online_event_ID { get; set; }
        public string online_event_name { get; set; }
        public string online_event_date { get; set; }
        public string online_event_time { get; set; }
        public string online_event_platform { get; set; }
        public string online_event_category { get; set; }
    }
}
