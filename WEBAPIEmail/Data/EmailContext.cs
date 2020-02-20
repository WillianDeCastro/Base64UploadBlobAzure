using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WEBAPIEmail.Data
{
    public class EmailContext : DbContext
    {

        public EmailContext(DbContextOptions<EmailContext> opt) : base(opt)
        {

        }


        public DbSet<EmaislEnviados> EmaislEnviados { get; set; }
    }
}
