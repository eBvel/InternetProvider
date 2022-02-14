namespace Model
{
    using Model.Entites;
    using System.Data.Entity;

    public class Context : DbContext
    {

        public Context()
            : base("name=InternetProviderConnection") {}

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<ReportMonth> ReportMonths { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}