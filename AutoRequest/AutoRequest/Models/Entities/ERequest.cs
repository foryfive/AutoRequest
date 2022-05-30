using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRequest.Models.Entities
{
    [Table("Request")]
    public class ERequest
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Url { get; set; }
        public TimeSpan Inteval { get; set; }
        public string Estatus { get; set; }
    }
}
