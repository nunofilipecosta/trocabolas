namespace TrocaBolas.Infrastructure.Database.Mappings
{
    using System.Data.Entity.ModelConfiguration;
    using Domain.Entities;

    public class TrocaBolasProductMapping : EntityTypeConfiguration<Product>
    {
        public TrocaBolasProductMapping()
        {
            this.HasKey(p => p.ProductId);
            ToTable("Products");
        }
    }
}