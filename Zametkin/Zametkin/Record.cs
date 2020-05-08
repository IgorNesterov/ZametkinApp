using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zametkin
{
    [Table("Records")]
    public class Record
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [Unique] public string Name { get; set; }
        public string Text { get; set; }
        public string Geometka { get; set; }
    }
}
