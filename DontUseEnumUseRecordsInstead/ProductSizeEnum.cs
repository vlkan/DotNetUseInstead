using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DontUseEnumUseRecordsInstead;

public enum ProductSizeEnum
{
    Small = 1,
    Medium = 2,
    Large = 3,
    [Display(Name = "Extra Large")]
    XLarge = 4,
    XXLarge = 5,
}
