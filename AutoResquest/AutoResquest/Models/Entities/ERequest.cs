using SQLite;
using System;

namespace AutoRequest.Models.Entities
{
    [Table("Request")]
    public class ERequest
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Url { get; set; }
        public TimeSpan Inteval { get; set; }
        public string Estatus { get; set; }
    }
}
