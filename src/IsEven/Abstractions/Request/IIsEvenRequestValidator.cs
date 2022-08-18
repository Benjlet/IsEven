using IsEven.Abstractions.Response;

namespace IsEven.Abstractions
{
    internal interface IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate(int number);
    }
}