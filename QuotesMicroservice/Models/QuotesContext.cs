using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesMicroservice.Models
{
    public class QuotesContext:DbContext 
    {
        public QuotesContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<QuotesMaster> QuotesMasters { get; set; }
    }
}
