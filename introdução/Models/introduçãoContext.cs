using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace introdução.Models
{
    public class introduçãoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public introduçãoContext() : base("name=introduçãoContext")
        {
        }

        public System.Data.Entity.DbSet<ProjetoASPNET_VazioComCRUD_EF6.Models.banco> bancoes { get; set; }

    }

    public class introduçãoContext2 : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public introduçãoContext2() : base("name=introduçãoContext")
        {
        }

        public System.Data.Entity.DbSet<CRUD_EF.Models.cadUser> cadUsers { get; set; }
    }
}
