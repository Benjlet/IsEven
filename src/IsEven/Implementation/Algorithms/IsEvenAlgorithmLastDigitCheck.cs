﻿using IsEven.Base;
using IsEven.Implementation.Algorithms.Calculators;
using IsEven.Implementation.Algorithms.Response;

namespace IsEven.Implementation.Algorithms
{
    internal class IsEvenAlgorithmLastDigitCheck : IsEvenAlgorithm
    {
        public IsEvenAlgorithmLastDigitCheck() : base(
            new IsEvenAlgorithmResponseHandler(),
            new IsEvenAlgorithmLastDigitCheckCalculator())
        {

        }
    }
}