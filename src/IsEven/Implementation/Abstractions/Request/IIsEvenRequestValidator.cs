using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Abstractions.Request
{
    internal interface IIsEvenRequestValidator
    {
        public IIsEvenValidationResponse Validate(int number);
    }
}