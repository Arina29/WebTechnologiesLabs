using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Web.Models;


namespace eUseControl.Web.Data
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=arinaDb") // connectionstring name define in your web.config
        {

        }

        public DbSet<userInfo> Users { get; set; }
        public DbSet<StyleTypes> designStyles { get; set; }
    }
}