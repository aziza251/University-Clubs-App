using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club.DataTransactions
{
    public class DBTrans
    {
            public string dbPath;
            private SQLiteConnection conn;

            public DBTrans(string _dbPath)
            {
                this.dbPath = _dbPath;
                Init();
            }
            public void Init()
            {
                conn = new SQLiteConnection(this.dbPath);
                conn.CreateTable<Models.ClubClass>();
                conn.CreateTable<Models.ManagerClass>();
                conn.CreateTable<Models.EventClass>();
                conn.CreateTable<Models.OnlineClass>();
                conn.CreateTable<Models.OfflineClass>();
                conn.CreateTable<Models.AssignClass>();

        }

            public List<Models.ClubClass> GetClubs()
            {
                Init();
                return conn.Table<Models.ClubClass>().ToList();
            }
            public List<Models.ManagerClass> GetManagers()
            {
                Init();
                return conn.Table<Models.ManagerClass>().ToList();
            }

            public List<Models.EventClass> GetEvents()
            {
                Init();
                return conn.Table<Models.EventClass>().ToList();
            }
            public List<Models.OnlineClass> GetOnlineEvents()
            {
                Init();
                return conn.Table<Models.OnlineClass>().ToList();

            }
        public List<Models.OfflineClass> GetOfflineEvents()
        {
            Init();
            return conn.Table<Models.OfflineClass>().ToList();

        }
        public List<Models.AssignClass> GetAssignList()
        {
            Init();
            return conn.Table<Models.AssignClass>().ToList();

        }

        public void Add(Models.ClubClass club)
            {
                conn = new SQLiteConnection(this.dbPath);
                conn.Insert(club);
            }
            public void Delete(int club_id)
            {
                var remove_club = conn.Table<Models.ClubClass>().FirstOrDefault(e => e.club_ID == club_id);
                if (remove_club != null)
                {
                    conn.Delete(remove_club);
                }
            }

            public void Add(Models.ManagerClass manager)
            {
                conn = new SQLiteConnection(this.dbPath);
                conn.Insert(manager);
            }

            public void Deletee(int manager_id)
            {
                var remove_manager = conn.Table<Models.ManagerClass>().FirstOrDefault(e => e.manager_ID == manager_id);
                if (remove_manager != null)
                {
                    conn.Delete(remove_manager);
                }
            }
            public void Add(Models.EventClass eventt)
             {
                conn = new SQLiteConnection(this.dbPath);
                conn.Insert(eventt);
             }

            public void Deleteee(int event_id)
            {
                var remove_event = conn.Table<Models.EventClass>().FirstOrDefault(e => e.event_ID == event_id);
                if (remove_event != null)
                {
                    conn.Delete(remove_event);
                }
            }

            public void Add(Models.OnlineClass onlineEvent)
            {
                conn = new SQLiteConnection(this.dbPath);
                conn.Insert(onlineEvent);
            }

            public void Deleteeee(int online_event_id)
            {
                var remove_online = conn.Table<Models.OnlineClass>().FirstOrDefault(e => e.online_event_ID == online_event_id);
                if (remove_online != null)
                {
                    conn.Delete(remove_online);
                }
            }

        public void Add(Models.OfflineClass offlineEvent)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(offlineEvent);
        }

        public void Deleteeeee(int offline_event_id)
        {
            var remove_offline = conn.Table<Models.OfflineClass>().FirstOrDefault(e => e.offline_event_ID == offline_event_id);
            if (remove_offline != null)
            {
                conn.Delete(remove_offline);
            }
        }

        public void Add(Models.AssignClass assign)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(assign);
        }
        public void Deleteeeeee(int assign_id)
        {
            var remove_assign = conn.Table<Models.AssignClass>().FirstOrDefault(e => e.assign_ID == assign_id);
            if (remove_assign != null)
            {
                conn.Delete(remove_assign);
            }
        }


    }
    }

