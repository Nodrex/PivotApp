using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotApp2
{
    [Table]
    public class Note
    {
        [Column(IsPrimaryKey=true , IsDbGenerated=false , CanBeNull = false)]
        public string Text
        {
            get;
            set;
        }
    }
}