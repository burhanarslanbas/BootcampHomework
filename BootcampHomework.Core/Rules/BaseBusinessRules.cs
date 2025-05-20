using Core.Exceptions.Types;

namespace Core.Rules;

public abstract class BaseBusinessRules
{
    protected void ThrowBusinessException(string message)
    {
        throw new BusinessException(message);
    }
}
