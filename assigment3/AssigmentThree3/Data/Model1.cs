namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// Code first entity model of Test table
    /// </summary>
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Test>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
