namespace RepositoryPatternNet6.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string PictureUrl { get; set; } = string.Empty;
        public ProductType? ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrands? ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
        

    }
}
