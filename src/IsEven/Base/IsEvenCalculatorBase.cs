using IsEven.Abstractions;
using IsEven.Abstractions.Response;

namespace IsEven.Base
{
    internal abstract class IsEvenCalculatorBase : IIsEvenCalculator
    {
        private readonly IIsEvenAlgorithm _isEvenAlgorithm;
        private readonly IIsEvenResponseHandler _isEvenResponseHandler;
        private readonly IIsEvenZeroIsEven _isEvenZeroIsEven;
        private readonly IIsEvenRequestValidator _isEvenRequestValidator;

        public IsEvenCalculatorBase(
            IIsEvenAlgorithm isEvenAlgorithm,
            IIsEvenRequestValidator isEvenRequestValidator,
            IIsEvenResponseHandler isEvenResponseHandler,
            IIsEvenZeroIsEven isEvenZeroIsEven)
        {
            _isEvenRequestValidator = isEvenRequestValidator;
            _isEvenResponseHandler = isEvenResponseHandler;
            _isEvenZeroIsEven = isEvenZeroIsEven;
            _isEvenAlgorithm = isEvenAlgorithm;
        }

        public bool IsEven(int number)
        {
            if (number == 0 && _isEvenZeroIsEven.IsZeroEven)
                return true;

            var validationResult = _isEvenRequestValidator.Validate(number);

            if (!validationResult.IsValid)
                throw new ArgumentException("Number argument is invalid.", nameof(number));

            var serviceResponse = _isEvenAlgorithm.Calculate(number);

            return _isEvenResponseHandler.GetResult(serviceResponse);
        }

        public bool IsOdd(int number)
        {
            return !IsEven(number);
        }

        public bool IsOddOrEven(int number)
        {
            return true;
        }
    }
}