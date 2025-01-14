using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
namespace GestionBanque.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<RIB> RIBs { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Reçu> Receipts { get; set; }
        public DbSet<Virement> Transfers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<CreditCard> creditCards { get; set; }
        public DbSet<Employe> employes { get; set; }
        public DbSet<prêt_bancaire> pr {  get; set; }
        public DbSet<Reçu> reçus { get; set; }
        public DbSet<RIB> rIBs { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<RegisterRequester> registerRequests { get; set; }
        public DbSet<LoginRequester> loginRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurations des relations et des contraintes

            // Relation Client - Account (1:N)
            modelBuilder.Entity<Account>()
                .HasOne<Client>()
                .WithMany(c => c.Accounts)
                .HasForeignKey(a => a.ClientId);

            // Relation Account - RIB (1:1)
            modelBuilder.Entity<Account>()
                .HasOne(a => a.RIB)
                .WithOne()
                .HasForeignKey<RIB>(r => r.Account);

            // Relation Deposit - Account (N:1)
            modelBuilder.Entity<Deposit>()
                .HasOne<Account>()
                .WithMany();

            // Relation Transfer - Account (N:1) pour le Sender
            modelBuilder.Entity<Virement>()
                .HasOne(v => v.SenderAccount) // Compte expéditeur
                .WithMany()
                .HasForeignKey(v => v.SenderAccount)
                .OnDelete(DeleteBehavior.Restrict); // Évite les suppressions en cascade

                modelBuilder.Entity<Virement>()
                    .HasOne(v => v.ReceiverAccount) // Compte destinataire
                    .WithMany()
                    .HasForeignKey(v => v.ReceiverAccount)
                    .OnDelete(DeleteBehavior.Restrict);
        }
}
}