using Lendtick.Product.Common;

namespace Lendtick.Product.Business.Validator
{
    internal interface IBaseValidator
    {
        IResultStatus Validate();
    }
}