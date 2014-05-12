namespace TrocaBolas.Infrastructure.Database.Mappings
{
    using System.Data.Entity.ModelConfiguration;
    using Domain.Entities;

    public class TrocaBolasUserProfileMapping : EntityTypeConfiguration<TrocaBolasUserProfile>
    {
        public TrocaBolasUserProfileMapping()
        {
            this.HasKey(u => u.UserId);
            this.Property(u => u.Name).IsRequired().HasMaxLength(500);
            this.Property(u => u.Address).IsRequired().HasMaxLength(500);
            this.Property(u => u.ZipCode).IsRequired().HasMaxLength(8);
        }
    }
}