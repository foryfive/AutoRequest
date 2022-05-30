using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace AutoRequest.Models
{
    public class Connection
    {
        private SQLiteConnection Conn;

        public Connection()
        {
            Conn = new SQLiteConnection("db");
        }
        public SQLiteConnection GetConn()
        {
            return this.Conn;
        }
    }
}
