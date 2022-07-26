using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class SqlParameters
    {
        public string DirectoryName { get; set; }
        public string ForeignIdName { get; set; }
        public string DataName { get; set; }
        public int Id { get; set; }
        public int ForeignId { get; set; }
        public int TypeSettlement { get; set; }
        public string NameSearch { get; set; }
    }
}
