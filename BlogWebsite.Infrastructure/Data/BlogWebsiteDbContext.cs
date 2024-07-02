using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebsite.Infrastructure.Data
{
    public class BlogWebsiteDbContext : IdentityDbContext<IdentityUser>
    {

        public BlogWebsiteDbContext(DbContextOptions<BlogWebsiteDbContext> optons):base(optons)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {




            base.OnConfiguring(optionsBuilder);
        }


    }
}
