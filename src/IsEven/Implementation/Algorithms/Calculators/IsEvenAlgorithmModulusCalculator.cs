﻿using IsEven.Implementation.Abstractions;
using System.Numerics;

namespace IsEven.Implementation.Algorithms.Calculators
{
    internal class IsEvenAlgorithmModulusCalculator : IIsEvenAlgorithmCalculator
    {
        public bool IsEven<T>(T number) where T : INumber<T>, IModulusOperators<T, T, T>
        {
            return number % T.CreateChecked(2) == T.Zero;
        }
    }
}