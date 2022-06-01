using AutoRequest.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AutoRequest.Models
{
    public class Request : Connection
    {
        private void CreateTable()
        {
            GetConn().CreateTable<ERequest>();
        }
        public void CreateOrUdate(ERequest request)
        {
            CreateTable();
            GetConn().Insert(request);
        }
        public void Delete(ERequest request)
        {
            CreateTable();
            GetConn().Delete(request);
        }
        public IEnumerable<ERequest> GetListActive()
        {
            CreateTable();
            return from data in GetConn().Table<ERequest>() select data;
        }
        public IEnumerable<ERequest> GetList()
        {
            CreateTable();
            return from data in GetConn().Table<ERequest>() select data;
        }
    }
}
