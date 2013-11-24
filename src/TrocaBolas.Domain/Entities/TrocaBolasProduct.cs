namespace TrocaBolas.Domain.Entities
{
    using System.Collections.Generic;

    public class TrocaBolasProduct
    {
        public int ProductId { get; set; }

        public ProductType ProductTypeId { get; set; }

        public int ProductOwnerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProductState ProductState { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<ProductPicture> Enumerable { get; set; }

        public int Visualizations { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public int PreservationState { get; set; }
    }
}