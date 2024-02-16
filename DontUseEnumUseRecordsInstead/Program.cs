using DontUseEnumUseRecordsInstead;

EnumExample enumExample = new EnumExample();
enumExample.Run();

public static class ProductSizeExtensions
{
    public static bool IsLargeType(ProductSizeEnum size)
    {
        return size == ProductSizeEnum.Large ||  size == ProductSizeEnum.XLarge || size == ProductSizeEnum.XXLarge;
    }
}

public class EnumExample
{
    public void Run()
    {
        int productSizeAsNumber = (int)ProductSizeEnum.Large;
        ProductSizeEnum productSizeEnum = (ProductSizeEnum)1;
    }
}

public class RecordExample
{
    public void Run()
    {
        ProductSizeRecord productSize = ProductSizeRecord.Large;

        int productSizeAsNumber = ProductSizeRecord.XXLarge;

        ProductSizeRecord sizeAsProductSizeType = 1;

        var ProductSizeAsName = ProductSizeRecord.XXLarge.ToString();
    }
}