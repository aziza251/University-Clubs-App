using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.Models
{
    public class AssignClass
    {
        [PrimaryKey, AutoIncrement]
        public int assign_ID {  get; set; }
        public string assign_club { get; set;}
        public string assign_manager { get; set;}  
    }
}
