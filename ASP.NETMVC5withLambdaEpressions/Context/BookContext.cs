using ASP.NETMVC5withLambdaEpressions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NETMVC5withLambdaEpressions.Context
{
    public class  BookContext : DbContext
    {
        public DbSet<Book> Books{ get; set; }
    }
}