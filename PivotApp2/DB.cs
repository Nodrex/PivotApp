using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotApp2
{
    public class DB : DataContext
    {
        public DB(string connectionString)
            : base(connectionString)
        {
        }

        public Table<Note> Notes
        {
            get
            {
                return this.GetTable<Note>();
            }
        }
    }
}