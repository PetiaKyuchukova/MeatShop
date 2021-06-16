namespace MeatShopForms
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MeatShop;

    public partial class database : DbContext
    {
        public database()
            : base("name=database")
        {
        }

        public virtual DbSet<Meat> Meats { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
