namespace IsEven.Abstractions.Response
{
    internal interface IIsEvenResponseHandler
    {
        public bool GetResult(IIsEvenAlgorithmResponse response);
    }
}