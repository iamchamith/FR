using FR.Domin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.DBAccess
{
    public class FRContext : DbContext
    {
        public FRContext() : base(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Malsha;Integrated Security=True;Pooling=False") { }

        public DbSet<Faces> Faces { get; set; }
    }
}
 
