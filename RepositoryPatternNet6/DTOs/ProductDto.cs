namespace RepositoryPatternNet6.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string PictureUrl { get; set; } = string.Empty;

        public string ProductTypeName { get; set; } = string.Empty;
        public string ProductBrandsName { get; set; } = string.Empty;
    }

}
