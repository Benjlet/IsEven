using IsEven.Implementation.Abstractions;
using IsEven.Implementation.Abstractions.Request;
using IsEven.Implementation.Abstractions.Response;
using IsEven.Implementation.Extensions;
using IsEven.Implementation.Request;
using System.Numerics;

namespace IsEven.Base
{
    internal abstract class IsEvenCalculatorBase : IIsEvenCalculator
    {
        private readonly IsEvenRequestValidatorRules _validatorRules;

        private readonly IIsEvenRequestValidator _isEvenRequestValidator;
        private readonly IIsEvenResponseHandler _isEvenResponseHandler;
        private readonly IIsEvenAlgorithm _isEvenAlgorithm;
        private readonly IIsEvenClientSettings _isEvenContext;

        public IsEvenCalculatorBase(
            IIsEvenAlgorithm isEvenAlgorithm,
            IIsEvenRequestValidator isEvenRequestValidator,
            IIsEvenResponseHandler isEvenResponseHandler,
            IIsEvenClientSettings isEvenContext)
        {
            _isEvenRequestValidator = isEvenRequestValidator;
            _isEvenResponseHandler = isEvenResponseHandler;
            _isEvenAlgorithm = isEvenAlgorithm;
            _isEvenContext = isEvenContext;

            _validatorRules = new IsEvenRequestValidatorRules(allowNonIntegers: !_isEvenContext.IntegersOnly);
        }

        public bool IsEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            IIsEvenValidationResponse validationResult = _isEvenRequestValidator.Validate(number, _validatorRules);

            if (_isEvenContext.IgnoreDecimalDigits)
            {
                number = T.CreateChecked(int.Parse(number.ToString().LastCharacter()));
            }

            if (!validationResult.IsValid)
            {
                return false;
            }

            if (number == T.Zero)
            {
                return _isEvenContext.IsZeroEven;
            }

            IIsEvenAlgorithmResponse serviceResponse = _isEvenAlgorithm.Calculate(number);

            return _isEvenResponseHandler.GetResult(serviceResponse);
        }

        public bool IsOdd<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            IIsEvenValidationResponse validationResult = _isEvenRequestValidator.Validate(number, _validatorRules);

            if (_isEvenContext.IgnoreDecimalDigits)
            {
                number = T.CreateChecked(int.Parse(number.ToString().LastCharacter()));
            }

            if (!validationResult.IsValid)
            {
                return false;
            }

            if (number == T.Zero)
            {
                return !_isEvenContext.IsZeroEven;
            }

            IIsEvenAlgorithmResponse serviceResponse = _isEvenAlgorithm.Calculate(number);

            return !_isEvenResponseHandler.GetResult(serviceResponse);
        }

        public bool IsOddOrEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return IsEven(number) || IsOdd(number);
        }
    }
}