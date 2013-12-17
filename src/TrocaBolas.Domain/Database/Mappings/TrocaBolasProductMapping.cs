namespace TrocaBolas.Domain.Database.Mappings
{
    using System.Data.Entity.ModelConfiguration;

    using TrocaBolas.Domain.Entities;

    public class TrocaBolasProductMapping : EntityTypeConfiguration<TrocaBolasProduct>
    {
        public TrocaBolasProductMapping()
        {
            this.HasKey(p => p.ProductId);
            ToTable("Products");
        }
    }
}