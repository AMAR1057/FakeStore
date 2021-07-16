using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FakeStore
{
    public class Models : DbContext
    {
      
      public DbSet<AccountOrders> TotalOrders {get;set;}
      protected override void OnConfiguring(DbContextOptionsBuilder opt) 
        => opt.UseSqlite(@"Data Source=Item.sqlite");
}

    public class AccountOrders
    {
        public int Id { get; set; }   
          public string Inventory { get; set;}
          public string Cart { get; set; }
     
    }
}

          

    


