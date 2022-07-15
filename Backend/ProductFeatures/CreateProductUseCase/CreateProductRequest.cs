namespace ProductFeatures.CreateProductUseCase
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal ActualCost { get; set; }

        public int Quantity { get; set; }

        public int CategoryID { get; set; }
    }
}
