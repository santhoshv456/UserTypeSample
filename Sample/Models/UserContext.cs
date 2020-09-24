using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace Sample.Models
{
    public class UserContext:DbContext
    {  
        public UserContext():base("UserContext")
        { }
        public DbSet<UserType> usertype { get; set; }
    }
}