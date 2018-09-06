using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestingWebApp.Models
{
    public class JournalContext : DbContext
    {

        JournalContext(DbContextOptions<JournalContext> options)
            : base(options)
        {

        }

        public DbSet<JournalEntryModel> JournalEntries { get; set; }
    }
}
