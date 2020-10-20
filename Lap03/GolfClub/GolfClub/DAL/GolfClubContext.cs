using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfClub.Model;
using GolfClub.DAL;
using System.Data.Entity;

namespace GolfClub.DAL
{
    public class GolfClubContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}