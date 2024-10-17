namespace VerticalSlice.Contracts;

public class CreateProductRequest
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal UnitPrice { get; set; }
}
