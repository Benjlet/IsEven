using IsEven.Abstractions;
using IsEven.Abstractions.Response;

namespace IsEven.Base
{
    public abstract class IsEvenCalculator : IIsEvenCalculator
    {
        private readonly IIsEvenAlgorithm _isEvenAlgorithm;
        private readonly IIsEvenResponseHandler _isEvenResponseHandler;
        private readonly IIsEvenRequestValidator _isEvenRequestValidator;

        public IsEvenCalculator(
            IIsEvenAlgorithm isEvenAlgorithm,
            IIsEvenRequestValidator isEvenRequestValidator,
            IIsEvenResponseHandler isEvenResponseHandler)
        {
            _isEvenRequestValidator = isEvenRequestValidator;
            _isEvenResponseHandler = isEvenResponseHandler;
            _isEvenAlgorithm = isEvenAlgorithm;
        }

        public bool IsEven(int number)
        {
            var validationResult = _isEvenRequestValidator.Validate(number);

            if (!validationResult.IsValid)
                return false;

            var serviceResponse = _isEvenAlgorithm.Calculate(number);

            return _isEvenResponseHandler.GetResult(serviceResponse);
        }
    }
}