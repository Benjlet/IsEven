﻿using IsEven.Implementation.Abstractions.Response;

namespace IsEven.Implementation.Algorithms.Response
{
    internal class IsEvenAlgorithmResponseEven : IIsEvenAlgorithmResponse
    {
        public bool IsEven => true;
    }
}