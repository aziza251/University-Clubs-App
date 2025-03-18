using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.Models
{
    public  class ManagerClass
    {
        [PrimaryKey, AutoIncrement]
        public int manager_ID { get; set; }
        public string manager_Name {  get; set; }
        public string manager_Identity { get; set; }
        public string manager_Department { get; set;}
        public string manager_Year { get; set; }
 
    }
}
