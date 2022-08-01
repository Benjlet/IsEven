using IsEven.Abstractions.Response;

namespace IsEven.Abstractions
{
    public interface IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate(int number);
    }
}