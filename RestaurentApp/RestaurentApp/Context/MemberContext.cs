using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RestaurentApp.Models;

namespace RestaurentApp.Context
{
    public class MemberContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}