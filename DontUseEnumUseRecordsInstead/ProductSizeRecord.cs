namespace DontUseEnumUseRecordsInstead;

public record ProductSizeRecord(int value, string name)
{
    public static ProductSizeRecord Small { get; } = new ProductSizeRecord(1, "Small");
    public static ProductSizeRecord Medium { get; } = new ProductSizeRecord(2, "Medium");
    public static ProductSizeRecord Large { get; } = new ProductSizeRecord(3, "Large");
    public static ProductSizeRecord XLarge { get; } = new ProductSizeRecord(4, "XLarge");
    public static ProductSizeRecord XXLarge { get; } = new ProductSizeRecord(5, "XXLarge");

    public static implicit operator int(ProductSizeRecord size) => size.value;

    public static implicit operator ProductSizeRecord(int value) => value switch
    {
        1 => Small, 2 => Medium, 3 => Large, 4 => XLarge, 5 => XXLarge
    };

    public bool IsSizeInLargeType() => this == Large || this == XLarge || this == XXLarge;
    public override string ToString() => name;
}
