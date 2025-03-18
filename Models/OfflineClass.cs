using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.Models
{
    public  class OfflineClass
    {
        [PrimaryKey, AutoIncrement]
        public int offline_event_ID { get; set; }
        public string offline_event_name { get; set;}
        public string offline_event_date { get; set; }
        public string offline_event_time { get; set; }
        public string offline_event_place { get; set; }
        public string offline_event_category { get; set; }
    }
}
