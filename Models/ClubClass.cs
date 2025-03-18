using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.Models
{
    public class ClubClass
    {
        [PrimaryKey, AutoIncrement]
        public int club_ID {  get; set; } 
        public string club_Name { get; set; }
        public string club_Contact {  get; set; }
        public string club_language { get; set; }
        public string club_Category { get; set; }


    }
}
